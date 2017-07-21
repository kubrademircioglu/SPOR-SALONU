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
    public partial class AnasekreterSayfası : Form
    {
        public AnasekreterSayfası()
        {
            InitializeComponent();
        }
        Personel Personel = new Personel();
        private void button1_Click(object sender, EventArgs e)
        {
            Personel.Show();
        }
        SekreterGirisi SekreterGirisi = new SekreterGirisi();
        private void button2_Click(object sender, EventArgs e)
        {
            SekreterGirisi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
