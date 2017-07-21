using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Oracle.ManagedDataAccess.Client;
using System.Diagnostics;
namespace SporSalonuOtomasyonu
{
    public partial class Yedek : Form
    {
        public Yedek()
        {
            InitializeComponent();
        }
        public OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBAORACLE)));uSER id=system;password=Kubra1234;");
               

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sorgu = "drop table  YEDEKLENEN_HESAP";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch { this.Close(); }

            string sorgu1 = "create table YEDEKLENEN_HOCA as select * from  TB_HOCA";
            OracleCommand command1 = new OracleCommand(sorgu1, baglan);
            command1.ExecuteNonQuery();

            MessageBox.Show("Hesap tablosu yedeklendi");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu2 = "create table TB_HOCA as select * from  YEDEKLENEN_HOCA";
            OracleCommand command2 = new OracleCommand(sorgu2, baglan);
            command2.ExecuteNonQuery();

            MessageBox.Show("HOCA tablosu yedekden döndü");
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                baglan.Open();
                string sorgu = "drop table  YEDEKLENEN_UYE";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch { this.Close(); }

            string sorgu1 = "create table YEDEKLENEN_UYE as select * from  TB_UYE";
            OracleCommand command1 = new OracleCommand(sorgu1, baglan);
            command1.ExecuteNonQuery();

            MessageBox.Show("UYE tablosu yedeklendi");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                baglan.Open();
                string sorgu = "drop table  YEDEKLENEN_SEKRETER";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                command.ExecuteNonQuery();
                this.Close();
            }
            catch { this.Close(); }

            string sorgu1 = "create table YEDEKLENEN_SEKRETER as select * from  TB_SEKRETER";
            OracleCommand command1 = new OracleCommand(sorgu1, baglan);
            command1.ExecuteNonQuery();

            MessageBox.Show("SEKRETER tablosu yedeklendi");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //string sorgu1 = "drop table  TB_OGRENCI CASCADE CONSTRAINTS";
            //OracleCommand command1 = new OracleCommand(sorgu1, baglan);
            //command1.ExecuteNonQuery();
            //this.Close();

            string sorgu2 = "create table TB_UYE as select * from  YEDEKLENEN_UYE";
            OracleCommand command2 = new OracleCommand(sorgu2, baglan);
            command2.ExecuteNonQuery();

            MessageBox.Show("UYE tablosu yedekden döndü");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //string sorgu1 = "drop table  TB_OGRENCI CASCADE CONSTRAINTS";
            //OracleCommand command1 = new OracleCommand(sorgu1, baglan);
            //command1.ExecuteNonQuery();
            //this.Close();

            string sorgu2 = "create table TB_SEKRETER as select * from  YEDEKLENEN_SEKRETER";
            OracleCommand command2 = new OracleCommand(sorgu2, baglan);
            command2.ExecuteNonQuery();

            MessageBox.Show("SEKRETER tablosu yedekden döndü");
            this.Close();
        }
    }
}
