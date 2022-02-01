using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHastaneWithDatabase
{
    public partial class LoginScreen : Form
    {
        bool bKullaniciAdiYazdiMi = false;
        bool bSifreYazdiMi = false;
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterScreen registerScreen = new RegisterScreen(this);
            registerScreen.Show();
        }
        public void Show(string kullaniciAdi,string sifre)
        {
            this.Show();
            txtKullaniciAdi.ForeColor = Color.Black;
            txtSifre.ForeColor = Color.Black;
            txtKullaniciAdi.Text = kullaniciAdi;
            txtSifre.Text = sifre;
        }
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bKullaniciAdiYazdiMi == false)
            {
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.ForeColor = Color.Black;
                bKullaniciAdiYazdiMi = true;
                pbWarningKullaniciAdi.Visible = false;
            }
        }
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bSifreYazdiMi == false)
            {
                txtSifre.Clear();
                txtSifre.ForeColor = Color.Black;
                bSifreYazdiMi = true;
                pbWarningSifre.Visible = false;
            }
        }
        private void loginScreen_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text.Trim() == "")
            {
                txtKullaniciAdi.ForeColor = Color.Gray;
                txtKullaniciAdi.Text = "Kullanıcı Adı";
                bKullaniciAdiYazdiMi = false;
                pbWarningKullaniciAdi.Visible = true;
            }
            if (txtSifre.Text.Trim() == "")
            {
                txtSifre.ForeColor = Color.Gray;
                txtSifre.Text = "şifre";
                bSifreYazdiMi = false;
                pbWarningSifre.Visible = true;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sfr = txtSifre.Text;
            DBHASTANEEntities db = new DBHASTANEEntities();
            var kullanici = db.TBLGorevliler.FirstOrDefault(p => p.KullaniciAdi == kullaniciAdi && p.Sifre==sfr);
            if (kullanici != null)
            {
                HospitalScreen hospitalScreen = new HospitalScreen();
                this.Hide();
                hospitalScreen.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre yanlış!");
            }
        }
    }
}
