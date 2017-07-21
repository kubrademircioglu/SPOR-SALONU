using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace SporSalonuOtomasyonu
{
    public partial class SekreterGirisi : Form
    {
        public SekreterGirisi()
        {
            InitializeComponent();
        }
        
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
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

        private void SekreterGirisi_Load(object sender, EventArgs e)
        {

            comboBox5.Visible = false;
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            cmd = new OracleCommand("select * from TB_UYE", baglan); cmd.ExecuteNonQuery();
            da = new OracleDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            baglan.Close();
            textBox38.Visible = false;
        }
        
        UyeGirisi UyeGirisi = new UyeGirisi();
        UyeIslemleri UyeIslemleri = new UyeIslemleri();
        private void button13_Click(object sender, EventArgs e)
        {
            UyeGirisi.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime bTarih = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime kTarih = Convert.ToDateTime(dateTimePicker2.Text);
            TimeSpan Sonuc = kTarih - bTarih;
            comboBox3.Text = Convert.ToString(kTarih - bTarih);

            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string donustur2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            if (textBox3.Text == "" && textBox20.Text == "" && textBox22.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(UyeIslemleri.UKayitEkle(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text,donustur,comboBox3.Text,donustur2, textBox20.Text, textBox29.Text, textBox4.Text,textBox5.Text, textBox6.Text,richTextBox1.Text, richTextBox3.Text,textBox22.Text, textBox23.Text, textBox21.Text,comboBox6.Text));

                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text="";
                comboBox3.Text = "";
                 dateTimePicker2.Text="";
                textBox20.Text = "";
                textBox29.Text = "";
                textBox4.Text = "";
                
                textBox5.Text = "";
                textBox6.Text = "";
                richTextBox1.Text="";
                 richTextBox3.Text="";
            
                textBox22.Text = "";
                textBox23.Text = "";
                  textBox21.Text = "";
                  comboBox6.Text = "";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridKayitGoster();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();



            textBox20.Clear();
            textBox29.Clear();
            textBox4.Clear();

            textBox5.Clear();
            textBox6.Clear();
            richTextBox1.Clear();
            richTextBox3.Clear();

            textBox22.Clear();
            textBox23.Clear();
            textBox21.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
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
            textBox11.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dateTimePicker5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            dateTimePicker6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            
            textBox24.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox28.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
           
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            richTextBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            
            
            textBox26.Text = dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString();
            textBox27.Text = dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString();
            textBox30.Text = dataGridView1.Rows[e.RowIndex].Cells[17].Value.ToString();
        }
        public int userid;
        private void button4_Click(object sender, EventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            MessageBox.Show(UyeIslemleri.UKayitSil(userid));
            dataGridKayitGoster();
            textBox8.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            comboBox2.Text = "";
            dateTimePicker5.Text = "";
            comboBox7.Text = "";
            dateTimePicker6.Text = "";
            textBox24.Text = "";
            textBox28.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";

            textBox12.Text = "";

            richTextBox2.Text = "";
            richTextBox4.Text = "";

            textBox26.Text = "";
            textBox27.Text = "";
            textBox30.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string donustur3 = dateTimePicker5.Value.ToString("yyyy-MM-dd");
            string donustur4 = dateTimePicker6.Value.ToString("yyyy-MM-dd");
            if (textBox8.Text == "" && textBox7.Text == "" && textBox9.Text == "" && comboBox2.Text == "" && donustur3 == "" && comboBox7.Text == "" && donustur4 == "" && textBox24.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "" && richTextBox2.Text == "" && textBox26.Text == "" && textBox27.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(UyeIslemleri.UKayitGuncelle(userid, textBox8.Text, textBox7.Text, textBox9.Text, comboBox2.Text, donustur3, comboBox7.Text, donustur4, textBox24.Text, textBox28.Text, textBox10.Text, textBox11.Text, textBox12.Text, richTextBox2.Text, richTextBox4.Text, textBox26.Text, textBox27.Text, textBox30.Text,comboBox8.Text));
                dataGridKayitGoster();
                textBox8.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                comboBox2.Text = "";
                dateTimePicker5.Text = "";
                comboBox7.Text = "";
                dateTimePicker6.Text = "";
                textBox24.Text = "";
                textBox28.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";

                textBox12.Text = "";
               
                richTextBox2.Text = "";
                richTextBox4.Text = "";

                textBox26.Text = "";
                textBox27.Text = "";
                textBox30.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_UYE WHERE  AD='" + textBox13.Text + "'";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox13.Text = "";
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                label17.Text = "Ad Giriniz:";

            }
            if (comboBox4.SelectedIndex == 1)
            {
                label17.Text = "Soyad Giriniz:";

            }
            if (comboBox4.SelectedIndex == 2)
            {
                label17.Text = "TC Giriniz:";
            }
            if (comboBox4.SelectedIndex == 3)
            {
                label17.Text = "Görev Seçiniz:";
                comboBox5.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT * FROM TB_UYE WHERE  AD='" + textBox14.Text + "'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox14.Text = "";
                baglan.Close();
            }
            if (comboBox4.SelectedIndex == 1)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT * FROM TB_UYE WHERE  SOYAD='" + textBox14.Text + "'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox14.Text = "";
                baglan.Close();
            }
            if (comboBox4.SelectedIndex == 2)
            {
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT * FROM TB_UYE WHERE  TC='" + textBox14.Text + "'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox14.Text = "";
                baglan.Close();
            }
            if (comboBox4.SelectedIndex == 3)
            {
                label17.Text = "Görev Seçiniz:";
                textBox14.Visible = false;
                OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
                baglan.Open();
                string sorgu = "SELECT * FROM TB_UYE WHERE  MESLEK='" + comboBox5.Text + "'";
                OracleCommand command = new OracleCommand(sorgu, baglan);
                OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                textBox14.Text = "";
                baglan.Close();
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            //baglan.Open();
            //string sorgu = "SELECT * FROM TB_UYE WHERE  TC='" + textBox16.Text + "'";
            //OracleCommand command = new OracleCommand(sorgu, baglan);
            //OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            //DataSet ds = new DataSet();
            //oda.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //textBox16.Text = "";
            //baglan.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
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
            //textBox11.Text = "";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            string donustur3 = dateTimePicker5.Value.ToString("yyyy-MM-dd");
            string donustur4 = dateTimePicker6.Value.ToString("yyyy-MM-dd");
            if (textBox8.Text == "" && textBox7.Text == "" && textBox9.Text == "" && comboBox2.Text == "" && donustur3 == "" && comboBox7.Text == "" && donustur4 == "" && textBox24.Text == "" && textBox10.Text == "" && textBox11.Text == "" && textBox12.Text == "" && richTextBox2.Text == "" && textBox26.Text == "" && textBox27.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(UyeIslemleri.UKayitGuncelle(userid, textBox8.Text, textBox7.Text, textBox9.Text, comboBox2.Text, donustur3, comboBox7.Text, donustur4, textBox24.Text, textBox28.Text, textBox10.Text, textBox11.Text, textBox12.Text, richTextBox2.Text, richTextBox4.Text, textBox26.Text, textBox27.Text, textBox30.Text, comboBox8.Text));
                dataGridKayitGoster();
                textBox8.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                comboBox2.Text = "";
                dateTimePicker5.Text = "";
                comboBox7.Text = "";
                dateTimePicker6.Text = "";
                textBox24.Text = "";
                textBox28.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";

                textBox12.Text = "";

                richTextBox2.Text = "";
                richTextBox4.Text = "";

                textBox26.Text = "";
                textBox27.Text = "";
                textBox30.Text = "";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
