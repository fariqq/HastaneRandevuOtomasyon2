
namespace prjHastaneWithDatabase
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.pbWarningSifre = new System.Windows.Forms.PictureBox();
            this.pbWarningKullaniciAdi = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoginKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWarningSifre
            // 
            this.pbWarningSifre.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningSifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningSifre.BackgroundImage")));
            this.pbWarningSifre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningSifre.Location = new System.Drawing.Point(348, 234);
            this.pbWarningSifre.Name = "pbWarningSifre";
            this.pbWarningSifre.Size = new System.Drawing.Size(20, 20);
            this.pbWarningSifre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningSifre.TabIndex = 23;
            this.pbWarningSifre.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningSifre, "Şifre Girmek Zorunlu!");
            // 
            // pbWarningKullaniciAdi
            // 
            this.pbWarningKullaniciAdi.BackColor = System.Drawing.Color.LightCoral;
            this.pbWarningKullaniciAdi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWarningKullaniciAdi.BackgroundImage")));
            this.pbWarningKullaniciAdi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWarningKullaniciAdi.Location = new System.Drawing.Point(348, 188);
            this.pbWarningKullaniciAdi.Name = "pbWarningKullaniciAdi";
            this.pbWarningKullaniciAdi.Size = new System.Drawing.Size(20, 20);
            this.pbWarningKullaniciAdi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWarningKullaniciAdi.TabIndex = 22;
            this.pbWarningKullaniciAdi.TabStop = false;
            this.toolTip1.SetToolTip(this.pbWarningKullaniciAdi, "Kullanıcı Adı Girmek Zorunlu!");
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LightCoral;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(1073, 2);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 28);
            this.btnKapat.TabIndex = 21;
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Location = new System.Drawing.Point(503, 282);
            this.btnYeniUye.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(129, 35);
            this.btnYeniUye.TabIndex = 14;
            this.btnYeniUye.Text = "Yeni Üye";
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(366, 282);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(129, 35);
            this.btnGirisYap.TabIndex = 19;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.LightCoral;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(376, 232);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(279, 15);
            this.txtSifre.TabIndex = 18;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "________________________________";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.LightCoral;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Gray;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(376, 188);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(279, 15);
            this.txtKullaniciAdi.TabIndex = 16;
            this.txtKullaniciAdi.Text = "Kullanıcı Adı";
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "________________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 508);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoginKapat
            // 
            this.btnLoginKapat.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoginKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoginKapat.BackgroundImage")));
            this.btnLoginKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoginKapat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnLoginKapat.FlatAppearance.BorderSize = 0;
            this.btnLoginKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginKapat.Location = new System.Drawing.Point(963, -1);
            this.btnLoginKapat.Name = "btnLoginKapat";
            this.btnLoginKapat.Size = new System.Drawing.Size(28, 28);
            this.btnLoginKapat.TabIndex = 43;
            this.btnLoginKapat.UseVisualStyleBackColor = false;
            this.btnLoginKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(990, 494);
            this.Controls.Add(this.btnLoginKapat);
            this.Controls.Add(this.pbWarningSifre);
            this.Controls.Add(this.pbWarningKullaniciAdi);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYeniUye);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.toolTip1.SetToolTip(this, "Kullanıcı Adı Girmek Zorunlu!");
            this.Click += new System.EventHandler(this.loginScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningSifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWarningKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWarningSifre;
        private System.Windows.Forms.PictureBox pbWarningKullaniciAdi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnLoginKapat;
    }
}