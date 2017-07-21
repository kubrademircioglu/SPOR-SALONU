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
    public partial class HocaGirisi : Form
    {
        public HocaGirisi()
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
            string sorgu = "SELECT * FROM TB_RANDEVU";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

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
                textBox7.Text = "";
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
                textBox7.Text = "";
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
                textBox7.Text = "";
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
                textBox7.Text = "";
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
                textBox7.Text = "";
                baglan.Close();
            }













        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HocaGirisi_Load(object sender, EventArgs e)
        {
            textBox9.Visible = false;
            textBox7.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT UYE_ID,AD,SOYAD FROM TB_UYE WHERE TC='" + textBox8.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox9.Text = oku["UYE_ID"].ToString();
                textBox1.Text = oku["AD"].ToString();
                textBox2.Text = oku["SOYAD"].ToString();
            }
        }
        public int userid;
       
        private void button6_Click(object sender, EventArgs e)
        {
           // string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && comboBox4.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {
                //Convert.ToInt32(textBox9.Text)
               // MessageBox.Show(RandevuIslemleri.RandevuEkle(comboBox1.Text, donustur, comboBox2.Text));
                //MessageBox.Show(Beslenmeislemleri.Beslen(comboBox1.Text, comboBox4.Text, richTextBox1.Text,richTextBox2.Text,textBox9.Text));
               
                dataGridKayitGoster();
                //textBox1.Text = "";
                // textBox2.Text = "";
                //textBox3.Text = "";
                comboBox1.Text = "";
               
                richTextBox1.Text = "";



            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_UYE";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox5.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            
        }
       
        private void button8_Click(object sender, EventArgs e)
        {
           
               
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");


                baglan.Open();
                OracleCommand cmd = new OracleCommand("SELECT COUNT(SPOR_ADI) FROM TB_RANDEVU WHERE SPOR_ADI='HAVUZ'", baglan);
                textBox10.Text = cmd.ExecuteScalar().ToString();

                baglan.Close();

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
                textBox7.Text = "";
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
                textBox7.Text = "";
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
                textBox7.Text = "";
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
                textBox7.Text = "";
                baglan.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox11.Text = openFileDialog1.FileName;
            }
            string yolBaglantisi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBox11.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection con = new OleDbConnection(yolBaglantisi);
            OleDbDataAdapter myAdapter = new OleDbDataAdapter("select * from [Sayfa1$]", con);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                
                MessageBox.Show(RandevuIslemleri.RandevuEkle(dataGridView1[0, i].Value.ToString(), dataGridView1[1, i].Value.ToString(), dataGridView1[2, i].Value.ToString(), Convert.ToInt32(dataGridView1[3, i].Value)));

            }
            //dataGridKayitGoster();
            
        }

        RandevuIslemleri RandevuIslemleri = new RandevuIslemleri();
        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}