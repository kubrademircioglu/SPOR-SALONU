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
    public partial class Personel : Form
    {
        
        public Personel()
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
            string sorgu = "SELECT * FROM TB_PERSONEL";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            if (textBox1.Text == "" && textBox2.Text == "" && textBox7.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(kullaniciislemleri.PKayitEkle(textBox1.Text, textBox2.Text, textBox3.Text, comboBox2.Text, textBox10.Text, textBox4.Text, textBox11.Text, comboBox5.Text, textBox5.Text, textBox7.Text, comboBox1.Text, donustur,textBox9.Text,textBox23.Text));

                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";
                textBox10.Text = "";
                textBox4.Text = "";
                textBox11.Text = "";
                comboBox5.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                textBox9.Text = "";
                textBox23.Text = "";




            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("KIZ");

            comboBox2.Items.Add("ERKEK");

           // comboBox4.Items.Add("TEMIZLIKCI");
            //comboBox4.Items.Add("GÜVENLİKÇİ");
         

            
            comboBox5.Items.Add("HOCA");
            comboBox5.Items.Add("SEKRETER");
          
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public int userid;
        private void button3_Click(object sender, EventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            MessageBox.Show(kullaniciislemleri.PKayitSil(userid));
            dataGridKayitGoster();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            textBox10.Text = "";
            textBox4.Text = "";
            textBox11.Text = "";
            comboBox5.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Text = "";


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Admin.Show();
            // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //Admin Admin1 = new Admin();
        private void button8_Click(object sender, EventArgs e)
        {

            //Admin1.Show();
            this.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_PERSONEL ";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string donustur2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            if (textBox22.Text == "" && textBox21.Text == "" && textBox20.Text == "" && comboBox3.Text == "" && textBox15.Text == "" && textBox19.Text == "" && textBox14.Text == "" && comboBox6.Text == "" && textBox16.Text == "" && textBox18.Text == "" && comboBox4.Text == "" && donustur2 == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(kullaniciislemleri.PKayitGuncelle(userid,textBox22.Text, textBox21.Text, textBox20.Text, comboBox3.Text, textBox15.Text, textBox19.Text, textBox14.Text, comboBox6.Text, textBox16.Text, textBox18.Text, comboBox4.Text, donustur2,textBox25.Text,textBox24.Text));
                dataGridKayitGoster();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox2.Text = "";
                textBox10.Text = "";
                textBox4.Text = "";
                textBox11.Text = "";
                comboBox6.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
                dateTimePicker1.Text = "";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_PERSONEL";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox22.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox21.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox20.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox15.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox19.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox14.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            textBox16.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            textBox18.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            textBox25.Text = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            textBox24.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_PERSONEL WHERE  TC='" + textBox8.Text + "'";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox8.Text = "";

            
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {
            
        }
        UyeGirisi UyeGirisi = new UyeGirisi();
        private void button5_Click_1(object sender, EventArgs e)
        {
            UyeGirisi.Show();
            this.Hide();
        }
    }
}