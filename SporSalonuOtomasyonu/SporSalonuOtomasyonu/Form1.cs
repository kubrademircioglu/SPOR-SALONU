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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void lblKullaniciAd_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblParola_Click(object sender, EventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }
        KullaniciGirisi kullanici=new KullaniciGirisi();
        Admin Admin = new Admin();
        HocaGirisi HocaGirisi = new HocaGirisi();
        AnasekreterSayfası AnasekreterSayfası = new AnasekreterSayfası();
        YenıHoca YenıHoca = new YenıHoca();
  
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sonuc = kullanici.girisYap(txtKullaniciAd.Text, txtParola.Text);
            if (sonuc == "ADMIN")
            {

                Admin.Show();
                this.Hide();
                              




            }
            else if (sonuc == "SEKRETER")
            {

                AnasekreterSayfası.Show();
                this.Hide();


            }
            else if (sonuc == "HOCA")

            {
                //YenıHoca.Show();
                HocaGirisi.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Yanlış Kullanıcı Adi veya Şifre Girişi...");
                
            }

        }

        private void grpKullaniciGirisBox_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                  
        }
    }
}
