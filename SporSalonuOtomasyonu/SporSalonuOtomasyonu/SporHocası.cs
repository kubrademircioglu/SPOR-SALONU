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
    public partial class SporHocası : Form
    {
        string text = "HOCA";
        public SporHocası()
        {
            InitializeComponent();
            textBox16.Text = text;
        }
        public DataSet ds;
        public OracleDataReader dr;
        public OracleDataAdapter da;
        public OracleCommand cmd;
        public DataTable dt;
     HocaIslemleri hocaislemleri = new HocaIslemleri();
        public void dataGridKayitGoster()
        {
            string sorgu = "SELECT * FROM TB_HOCA";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_PERSONEL WHERE  GOREV='HOCA'";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");
           


            if (textBox1.Text == "" && textBox28.Text == "" && textBox14.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(hocaislemleri.HKayitEkle(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, donustur, richTextBox3.Text,textBox4.Text,textBox5.Text, comboBox3.Text, richTextBox1.Text, textBox28.Text, textBox14.Text, textBox15.Text, textBox16.Text));

                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                richTextBox3.Text = "";

                textBox4.Text = "";
                textBox5.Text = "";
                comboBox3.Text = "";
                richTextBox1.Text = "";
                
                textBox28.Text = "";
                textBox14.Text = "";
                textBox15.Text = "";
                textBox16.Text = "";
                
                




            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SporHocası_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("KIZ");

            comboBox1.Items.Add("ERKEK");

            comboBox3.Items.Add("PLATES");

            comboBox3.Items.Add("ZUMBA");

            comboBox3.Items.Add("AEROBİK");
            comboBox3.Items.Add("VÜCUT GELİŞTİRME");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

            textBox2.Clear();
            textBox3.Clear();


            richTextBox3.Clear();

            textBox4.Clear();
            textBox5.Clear();

            richTextBox1.Clear();

            textBox28.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_HOCA";
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
            dateTimePicker5.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            richTextBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            richTextBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox17.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox19.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            
            
        }
        public int userid;
        private void button4_Click(object sender, EventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show(hocaislemleri.HKayitSil(userid));
            dataGridKayitGoster();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";
            richTextBox3.Text = "";

            textBox4.Text = "";
            textBox5.Text = "";
            comboBox3.Text = "";
            richTextBox1.Text = "";

            textBox28.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox8.Clear();

            textBox7.Clear();
            textBox9.Clear();


            richTextBox4.Clear();

            textBox10.Clear();
            textBox11.Clear();

            richTextBox2.Clear();

            textBox6.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string donustur2 = dateTimePicker5.Value.ToString("yyyy-MM-dd");
            if (textBox8.Text == "" && textBox7.Text == "" && textBox9.Text == "" && comboBox2.Text == "" && donustur2 == "" && richTextBox4.Text == "" && textBox10.Text == "" && textBox11.Text == "" && comboBox4.Text == "" && richTextBox2.Text == "" && textBox6.Text == "" && textBox17.Text == "" && textBox18.Text == "" && textBox19.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(hocaislemleri.HKayitGuncelle(userid,textBox8.Text, textBox7.Text, textBox9.Text, comboBox2.Text, donustur2, richTextBox4.Text, textBox10.Text, textBox11.Text,comboBox4.Text,richTextBox2.Text, textBox6.Text, textBox17.Text, textBox18.Text, textBox19.Text));
                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";
                textBox10.Text = "";
                textBox4.Text = "";
                textBox11.Text = "";
                textBox6.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_HOCA";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_HOCA WHERE  TC='" + textBox12.Text + "'";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox12.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
