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
    public partial class RegisterScreen : Form
    {
        bool adYazdiMi = false;
        bool soyadYazdiMi = false;
        bool kullaniciAdiYazdiMi = false;
        bool sifreYazdiMi = false;
        LoginScreen loginScreen;
        public RegisterScreen(LoginScreen loginScreen)
        {
            this.loginScreen = loginScreen;
            InitializeComponent();
        }
        private void btnYeniUye_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "Ad" && txtSoyad.Text != "Soyad" && txtKullaniciAdi.Text != "Kullanıcı Adı" && txtSifre.Text != "Şifre")
            {
                DBHASTANEEntities db = new DBHASTANEEntities();
                TBLGorevliler gorevli = new TBLGorevliler();
                gorevli.GorevliAd = txtAd.Text;
                gorevli.GorevliSoyad = txtSoyad.Text;
                gorevli.KullaniciAdi = txtKullaniciAdi.Text;
                gorevli.Sifre = txtSifre.Text;
                db.TBLGorevliler.Add(gorevli);
                db.SaveChanges();
                MessageBox.Show("Başarılı bir şekilde üye olundu.", "Üyelik Tamamlandı!");
                this.Hide();
                loginScreen.Show(txtKullaniciAdi.Text, txtSifre.Text);
            }
            else
            {
                MessageBox.Show("Alanların doldurulması zorunludur!", "Uyarı!");
            }
        }
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (adYazdiMi == false)
            {
                txtAd.Clear();
                txtAd.ForeColor = Color.Black;
                adYazdiMi = true;
                pbWarningAd.Visible = false;
            }
        }
        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (soyadYazdiMi == false)
            {
                txtSoyad.Clear();
                txtSoyad.ForeColor = Color.Black;
                soyadYazdiMi = true;
                pbWarningSoyad.Visible = false;
            }
        }
        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (kullaniciAdiYazdiMi == false)
            {
                txtKullaniciAdi.Clear();
                txtKullaniciAdi.ForeColor = Color.Black;
                kullaniciAdiYazdiMi = true;
                pbWarningKullanıcıAdı.Visible = false;
            }
        }
        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sifreYazdiMi == false)
            {
                txtSifre.Clear();
                txtSifre.ForeColor = Color.Black;
                sifreYazdiMi = true;
                pbWarningSifre.Visible = false;
            }
        }
        private void registerScreen_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() == "")
            {
                txtAd.ForeColor = Color.Gray;
                txtAd.Text = "Kullanıcı Adı";
                adYazdiMi = false;
                pbWarningAd.Visible = true;
            }
            if (txtSoyad.Text.Trim() == "")
            {
                txtSoyad.ForeColor = Color.Gray;
                txtSoyad.Text = "şifre";
                soyadYazdiMi = false;
                pbWarningSoyad.Visible = true;
            }
            if (txtKullaniciAdi.Text.Trim() == "")
            {
                txtKullaniciAdi.ForeColor = Color.Gray;
                txtKullaniciAdi.Text = "Kullanıcı Adı";
                kullaniciAdiYazdiMi = false;
                pbWarningKullanıcıAdı.Visible = true;
            }
            if (txtSifre.Text.Trim() == "")
            {
                txtSifre.ForeColor = Color.Gray;
                txtSifre.Text = "şifre";
                sifreYazdiMi = false;
                pbWarningSifre.Visible = true;
            }
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.Show();
        }
    }
}
