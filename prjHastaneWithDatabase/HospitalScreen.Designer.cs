
namespace prjHastaneWithDatabase
{
    partial class HospitalScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGuncelleme = new System.Windows.Forms.Label();
            this.lblSilme = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblPoliklinik = new System.Windows.Forms.Label();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.rbtnBay = new System.Windows.Forms.RadioButton();
            this.rbtnBayan = new System.Windows.Forms.RadioButton();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(391, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1077, 365);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblGuncelleme
            // 
            this.lblGuncelleme.AutoSize = true;
            this.lblGuncelleme.Location = new System.Drawing.Point(13, 406);
            this.lblGuncelleme.Name = "lblGuncelleme";
            this.lblGuncelleme.Size = new System.Drawing.Size(880, 17);
            this.lblGuncelleme.TabIndex = 24;
            this.lblGuncelleme.Text = "*Güncelleme İşlemi : Listeden isteğiniz satırı seçip Hasta Bilgileri kısmında ger" +
    "ekli değişiklikleri yaptıktan sonra Güncelle butonuna tıklayınız.";
            // 
            // lblSilme
            // 
            this.lblSilme.AutoSize = true;
            this.lblSilme.Location = new System.Drawing.Point(22, 406);
            this.lblSilme.Name = "lblSilme";
            this.lblSilme.Size = new System.Drawing.Size(433, 17);
            this.lblSilme.TabIndex = 23;
            this.lblSilme.Text = "*Silme işlemi : Listeden istediğiniz satırı seçip Sil butonuna tıklayınız.";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(274, 369);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(106, 29);
            this.btnGuncelle.TabIndex = 22;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            this.btnGuncelle.MouseHover += new System.EventHandler(this.btnGuncelle_MouseHover);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(139, 369);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 29);
            this.btnSil.TabIndex = 21;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            this.btnSil.MouseHover += new System.EventHandler(this.btnSil_MouseHover);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(6, 369);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(106, 29);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHastaID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtpRandevuTarihi);
            this.groupBox1.Controls.Add(this.lblPoliklinik);
            this.groupBox1.Controls.Add(this.cbPoliklinik);
            this.groupBox1.Controls.Add(this.rbtnBay);
            this.groupBox1.Controls.Add(this.rbtnBayan);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDogumYeri);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTCNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 340);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgileri";
            // 
            // txtHastaID
            // 
            this.txtHastaID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtHastaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHastaID.Enabled = false;
            this.txtHastaID.ForeColor = System.Drawing.Color.Black;
            this.txtHastaID.Location = new System.Drawing.Point(125, 30);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.Size = new System.Drawing.Size(234, 22);
            this.txtHastaID.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Randevu Tarihi";
            // 
            // dtpRandevuTarihi
            // 
            this.dtpRandevuTarihi.Location = new System.Drawing.Point(125, 290);
            this.dtpRandevuTarihi.Name = "dtpRandevuTarihi";
            this.dtpRandevuTarihi.Size = new System.Drawing.Size(234, 22);
            this.dtpRandevuTarihi.TabIndex = 16;
            // 
            // lblPoliklinik
            // 
            this.lblPoliklinik.AutoSize = true;
            this.lblPoliklinik.Location = new System.Drawing.Point(7, 258);
            this.lblPoliklinik.Name = "lblPoliklinik";
            this.lblPoliklinik.Size = new System.Drawing.Size(62, 17);
            this.lblPoliklinik.TabIndex = 15;
            this.lblPoliklinik.Text = "Poliklinik";
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.BackColor = System.Drawing.SystemColors.Control;
            this.cbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Items.AddRange(new object[] {
            "ALGOLOJİ",
            "BESLENME VE DİYET",
            "ÇOCUK ALERJİSİ",
            "DERMATOLOJİ (CİLDİYE)",
            "ENDOKRİNOLOJİ VE METABOLİZMA",
            "KULAK-BURUN-BOĞAZ HASTALIKLARI",
            "NEFROLOJİ",
            "NÖROLOJİ",
            "ORTOPEDİ VE TRAVMATOLOJİ",
            "PSİKİYATRİ"});
            this.cbPoliklinik.Location = new System.Drawing.Point(125, 256);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(234, 24);
            this.cbPoliklinik.TabIndex = 14;
            // 
            // rbtnBay
            // 
            this.rbtnBay.AutoSize = true;
            this.rbtnBay.Location = new System.Drawing.Point(247, 158);
            this.rbtnBay.Name = "rbtnBay";
            this.rbtnBay.Size = new System.Drawing.Size(53, 21);
            this.rbtnBay.TabIndex = 13;
            this.rbtnBay.TabStop = true;
            this.rbtnBay.Text = "Bay";
            this.rbtnBay.UseVisualStyleBackColor = true;
            // 
            // rbtnBayan
            // 
            this.rbtnBayan.AutoSize = true;
            this.rbtnBayan.Location = new System.Drawing.Point(159, 158);
            this.rbtnBayan.Name = "rbtnBayan";
            this.rbtnBayan.Size = new System.Drawing.Size(69, 21);
            this.rbtnBayan.TabIndex = 12;
            this.rbtnBayan.TabStop = true;
            this.rbtnBayan.Text = "Bayan";
            this.rbtnBayan.UseVisualStyleBackColor = true;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.Control;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Location = new System.Drawing.Point(125, 223);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(234, 22);
            this.txtTelefon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefon";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.BackColor = System.Drawing.SystemColors.Control;
            this.txtDogumYeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDogumYeri.Location = new System.Drawing.Point(125, 190);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(234, 22);
            this.txtDogumYeri.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Yeri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cinsiyet";
            // 
            // txtTCNo
            // 
            this.txtTCNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtTCNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTCNo.Location = new System.Drawing.Point(125, 124);
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(234, 22);
            this.txtTCNo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC Kimlik No";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoyad.Location = new System.Drawing.Point(125, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(234, 22);
            this.txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.BackColor = System.Drawing.SystemColors.Control;
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAd.Location = new System.Drawing.Point(125, 58);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(234, 22);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.LightCoral;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Location = new System.Drawing.Point(1475, -1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(28, 28);
            this.btnKapat.TabIndex = 26;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // HospitalScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1502, 431);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGuncelleme);
            this.Controls.Add(this.lblSilme);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HospitalScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HospitalScreen";
            this.Load += new System.EventHandler(this.HospitalScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGuncelleme;
        private System.Windows.Forms.Label lblSilme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpRandevuTarihi;
        private System.Windows.Forms.Label lblPoliklinik;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.RadioButton rbtnBay;
        private System.Windows.Forms.RadioButton rbtnBayan;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKapat;
    }
}