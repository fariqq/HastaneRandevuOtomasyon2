
namespace prjHastaneWithDatabase
{
    partial class RegisterScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            this.btnKapat = new System.Windows.Forms.Button();
            this.pbWarningSifre = new System.Windows.Forms.PictureBox();
            this.pbWarningKullanıcıAdı = new System.Windows.Forms.PictureBox();
            this.pbWarningSoyad = new System.Windows.Forms.PictureBox();
            this.pbWarningAd = new System.Windows.Forms.PictureBox();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningKullanıcıAdı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSoyad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningAd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LightCoral;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(340, -1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 28);
            this.btnKapat.TabIndex = 42;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // pbWarningSifre
            // 
            this.pbWarningSifre.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningSifre.BackgroundImage")));
            this.pbWarningSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningSifre.Location = new System.Drawing.Point(54, 227);
            this.pbWarningSifre.Name = "pbWarningSifre";
            this.pbWarningSifre.Size = new System.Drawing.Size(20, 20);
            this.pbWarningSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningSifre.TabIndex = 41;
            this.pbWarningSifre.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningSifre, "Şifre Girmek Zorunlu!");
            // 
            // pbWarningKullanıcıAdı
            // 
            this.pbWarningKullanıcıAdı.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningKullanıcıAdı.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningKullanıcıAdı.BackgroundImage")));
            this.pbWarningKullanıcıAdı.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningKullanıcıAdı.Location = new System.Drawing.Point(54, 178);
            this.pbWarningKullanıcıAdı.Name = "pbWarningKullanıcıAdı";
            this.pbWarningKullanıcıAdı.Size = new System.Drawing.Size(20, 20);
            this.pbWarningKullanıcıAdı.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningKullanıcıAdı.TabIndex = 40;
            this.pbWarningKullanıcıAdı.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningKullanıcıAdı, "Kullanıcı Adı Girmek Zorunlu!");
            // 
            // pbWarningSoyad
            // 
            this.pbWarningSoyad.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningSoyad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningSoyad.BackgroundImage")));
            this.pbWarningSoyad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningSoyad.Location = new System.Drawing.Point(54, 130);
            this.pbWarningSoyad.Name = "pbWarningSoyad";
            this.pbWarningSoyad.Size = new System.Drawing.Size(20, 20);
            this.pbWarningSoyad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningSoyad.TabIndex = 39;
            this.pbWarningSoyad.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningSoyad, "Soyad Girmek Zorunlu!");
            // 
            // pbWarningAd
            // 
            this.pbWarningAd.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningAd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningAd.BackgroundImage")));
            this.pbWarningAd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningAd.Location = new System.Drawing.Point(54, 81);
            this.pbWarningAd.Name = "pbWarningAd";
            this.pbWarningAd.Size = new System.Drawing.Size(20, 20);
            this.pbWarningAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningAd.TabIndex = 38;
            this.pbWarningAd.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningAd, "Ad Girmek Zorunlu!");
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Location = new System.Drawing.Point(123, 293);
            this.btnYeniUye.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(129, 35);
            this.btnYeniUye.TabIndex = 29;
            this.btnYeniUye.Text = "Üye Ol";
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.LightCoral;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(84, 222);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(224, 20);
            this.txtSifre.TabIndex = 36;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "______________________________";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.LightCoral;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(84, 172);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(224, 20);
            this.txtKullaniciAdi.TabIndex = 34;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "______________________________";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.LightCoral;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtSoyad.Location = new System.Drawing.Point(84, 125);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(224, 20);
            this.txtSoyad.TabIndex = 32;
            this.txtSoyad.Text = "Soyad";
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "______________________________";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.Color.LightCoral;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.ForeColor = System.Drawing.Color.Gray;
            this.txtAd.Location = new System.Drawing.Point(84, 75);
            this.txtAd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(224, 20);
            this.txtAd.TabIndex = 30;
            this.txtAd.Text = "Ad";
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "______________________________";
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(367, 358);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.pbWarningSifre);
            this.Controls.Add(this.pbWarningKullanıcıAdı);
            this.Controls.Add(this.pbWarningSoyad);
            this.Controls.Add(this.pbWarningAd);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterScreen";
            this.Text = "RegisterScreen";
            this.Click += new System.EventHandler(this.registerScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningKullanıcıAdı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSoyad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.PictureBox pbWarningSifre;
        private System.Windows.Forms.PictureBox pbWarningKullanıcıAdı;
        private System.Windows.Forms.PictureBox pbWarningSoyad;
        private System.Windows.Forms.PictureBox pbWarningAd;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}