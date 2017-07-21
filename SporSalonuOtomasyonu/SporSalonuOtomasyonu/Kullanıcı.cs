using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SporSalonuOtomasyonu
{
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }

        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("HOCA");

            comboBox1.Items.Add("SEKRETER");

            comboBox1.Items.Add("ÜYE");
           

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
