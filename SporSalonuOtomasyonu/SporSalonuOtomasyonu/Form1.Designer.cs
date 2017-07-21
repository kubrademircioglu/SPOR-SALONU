namespace SporSalonuOtomasyonu
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpKullaniciGirisBox = new System.Windows.Forms.GroupBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblKullaniciAd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpKullaniciGirisBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKullaniciGirisBox
            // 
            this.grpKullaniciGirisBox.Controls.Add(this.btnGiris);
            this.grpKullaniciGirisBox.Controls.Add(this.txtParola);
            this.grpKullaniciGirisBox.Controls.Add(this.txtKullaniciAd);
            this.grpKullaniciGirisBox.Controls.Add(this.lblParola);
            this.grpKullaniciGirisBox.Controls.Add(this.lblKullaniciAd);
            this.grpKullaniciGirisBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKullaniciGirisBox.Location = new System.Drawing.Point(201, 205);
            this.grpKullaniciGirisBox.Name = "grpKullaniciGirisBox";
            this.grpKullaniciGirisBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpKullaniciGirisBox.Size = new System.Drawing.Size(296, 187);
            this.grpKullaniciGirisBox.TabIndex = 1;
            this.grpKullaniciGirisBox.TabStop = false;
            this.grpKullaniciGirisBox.Text = "Kullanıcı Girişi";
            this.grpKullaniciGirisBox.Enter += new System.EventHandler(this.grpKullaniciGirisBox_Enter);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(139, 139);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(86, 29);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(139, 93);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(138, 24);
            this.txtParola.TabIndex = 3;
            this.txtParola.TextChanged += new System.EventHandler(this.txtParola_TextChanged);
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(139, 55);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(138, 24);
            this.txtKullaniciAd.TabIndex = 2;
            this.txtKullaniciAd.TextChanged += new System.EventHandler(this.txtKullaniciAd_TextChanged);
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblParola.Location = new System.Drawing.Point(10, 89);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(72, 26);
            this.lblParola.TabIndex = 1;
            this.lblParola.Text = "Parola:";
            this.lblParola.Click += new System.EventHandler(this.lblParola_Click);
            // 
            // lblKullaniciAd
            // 
            this.lblKullaniciAd.AutoSize = true;
            this.lblKullaniciAd.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAd.Location = new System.Drawing.Point(7, 51);
            this.lblKullaniciAd.Name = "lblKullaniciAd";
            this.lblKullaniciAd.Size = new System.Drawing.Size(118, 26);
            this.lblKullaniciAd.TabIndex = 0;
            this.lblKullaniciAd.Text = "Kullanıcı Ad:";
            this.lblKullaniciAd.Click += new System.EventHandler(this.lblKullaniciAd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SporSalonuOtomasyonu.Properties.Resources._1fe87fc3_bd21_4267_8d8d_19f5dfcdfc6a;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 168);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(541, 404);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpKullaniciGirisBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpKullaniciGirisBox.ResumeLayout(false);
            this.grpKullaniciGirisBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKullaniciGirisBox;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblKullaniciAd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

