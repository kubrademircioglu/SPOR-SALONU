using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data.OleDb;
using System.IO;

namespace SporSalonuOtomasyonu
{
    public partial class YenıHoca : Form
    {
        public YenıHoca()
        {
            InitializeComponent();
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
        KullaniciIslemleri kullaniciislemleri = new KullaniciIslemleri();
        public void dataGridKayitGoster()
        {
            string sorgu = "SELECT * FROM TB_UYE";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        public int userid;
        RandevuIslemleri RandevuIslemleri = new RandevuIslemleri();
        private void button2_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && dateTimePicker1.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(RandevuIslemleri.RandevuGuncelle(userid, donustur, comboBox1.Text, richTextBox1.Text));
                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='HAVUZ'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox4.Text = "";
                baglan.Close();
                //dataGridKayitGoster();
            }
            if (comboBox2.SelectedIndex == 1)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='SAUNA'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox4.Text = "";
                baglan.Close();
                //dataGridKayitGoster();
            }
            if (comboBox2.SelectedIndex == 2)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='VUCUT GELİŞTİRME'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox1.Text = "";
                baglan.Close();
            }
            if (comboBox2.SelectedIndex == 3)
            {

                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='FİTNESS'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox4.Text = "";
                baglan.Close();
            }
            if (comboBox2.SelectedIndex == 3)
            {

                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='AEROBİK'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox4.Text = "";
                baglan.Close();
            }
            if (comboBox2.SelectedIndex == 3)
            {

                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT AD,SOYAD,TC FROM TB_UYE o INNER JOIN TB_RANDEVU t ON o.UYE_ID=t.UYE_ID WHERE SPOR_ADI='ZUMBA'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox4.Text = "";
                baglan.Close();
            }











        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(Missing);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();


                }
            }
        }
        UyeIslemleri UyeIslemleri = new UyeIslemleri();
        private void button4_Click(object sender, EventArgs e)
        {
            //    OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //    if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        this.textBox6.Text = openFileDialog1.FileName;
            //    }
            //    string yolBaglantisi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox6.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            //    OleDbConnection con = new OleDbConnection(yolBaglantisi);
            //    OleDbDataAdapter myAdapter = new OleDbDataAdapter("select * from [Sayfa1$]", con);
            //    DataTable dt = new DataTable();
            //    myAdapter.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            //    {
            //        MessageBox.Show(UyeIslemleri.UKayitEkle(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), dataGridView1[3, i].Value.ToString(), dataGridView1[4, i].Value.ToString(), dataGridView1[5, i].Value.ToString());

            //    }
            //    dataGridKayitGoster();

            //}
        }
    }
}
