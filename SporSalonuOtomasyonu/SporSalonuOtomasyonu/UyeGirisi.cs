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
    public partial class UyeGirisi : Form
    {
        public UyeGirisi()
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
            string sorgu = "SELECT * FROM TB_RANDEVU O INNER JOIN TB_UYE T ON O.UYE_ID =T.UYE_ID";
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
        }
        RandevuIslemleri RandevuIslemleri = new RandevuIslemleri();
        private void button8_Click(object sender, EventArgs e)
        {
            string donustur = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox1.Text == "" && dateTimePicker1.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                
               MessageBox.Show(RandevuIslemleri.RandevuEkle(comboBox1.Text, donustur, comboBox2.Text, Convert.ToInt32(textBox4.Text)));
                dataGridKayitGoster();
                textBox4.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";

                comboBox1.Text = "";
                dateTimePicker1.Text = "";
                comboBox1.Text = "";

            }
        }



        private void UyeGirisi_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ZUMBA");

            comboBox1.Items.Add("PLATES");
            comboBox1.Items.Add("BASKETBOL");

            comboBox1.Items.Add("HAVUZ");

            textBox4.Visible = false;
            textBox12.Visible = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;



            textBox6.Enabled = false;// TEXT BOXLARA VERI GIRISINI ENGELEMEK
            textBox7.Enabled = false;

            textBox10.Enabled = false;
            textBox11.Enabled = false; 
            //textBox9.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT UYE_ID,AD,SOYAD FROM TB_UYE WHERE TC='" + textBox3.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox4.Text = oku["UYE_ID"].ToString();
                textBox1.Text = oku["AD"].ToString();
                textBox2.Text = oku["SOYAD"].ToString();


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            string sorgu1 = "SELECT UYE_ID,AD,SOYAD FROM TB_UYE WHERE TC='" + textBox5.Text + "'";
            OracleCommand command = new OracleCommand(sorgu1, baglan);
            OracleDataReader oku;
            baglan.Open();
            oku = command.ExecuteReader();

            while (oku.Read())
            {
                textBox12.Text = oku["UYE_ID"].ToString();
                textBox6.Text = oku["AD"].ToString();
                textBox7.Text = oku["SOYAD"].ToString();


            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_RANDEVU O INNER JOIN TB_UYE T ON O.UYE_ID =T.UYE_ID WHERE  TC='" + textBox5.Text + "'";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }
        public int userid;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           textBox11.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            comboBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePicker3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            textBox13.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           // userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());





        }

        private void button1_Click(object sender, EventArgs e)
        {
            userid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());


            MessageBox.Show(RandevuIslemleri.RANDEVUSil(userid));
            dataGridKayitGoster();
            //textBox8.Text = "";
            textBox7.Text = "";
            textBox5.Text = "";
            //comboBox3.Text = "";
            //dateTimePicker2.Text = "";

            textBox6.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleConnection baglan = new OracleConnection("DATA SOURCE=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=DBORACLE)));uSER id=system;password=Kubra1234;");
            baglan.Open();
            string sorgu = "SELECT * FROM TB_RANDEVU O INNER JOIN TB_UYE T ON O.UYE_ID =T.UYE_ID";
            OracleCommand command = new OracleCommand(sorgu, baglan);
            OracleDataAdapter oda = new OracleDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            oda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();
            textBox11.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string donustur3 = dateTimePicker3.Value.ToString("yyyy-MM-dd");

            if ( comboBox4.Text == "" && donustur3 == "" && textBox13.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun");
            }
            else
            {

                MessageBox.Show(RandevuIslemleri.RandevuGuncelle(userid,  comboBox4.Text, donustur3, textBox13.Text));
               //dataGridKayitGoster();
                
                comboBox4.Text = "";
                dateTimePicker3.Text = "";

                textBox13.Text = "";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}