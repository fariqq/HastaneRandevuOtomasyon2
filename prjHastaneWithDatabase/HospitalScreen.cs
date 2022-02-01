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
    public partial class HospitalScreen : Form
    {
        public HospitalScreen()
        {
            InitializeComponent();
        }
        private void HospitalScreen_Load(object sender, EventArgs e)
        {
            hastaListele();
            lblSilme.Visible = false;
            lblGuncelleme.Visible = false;
        }
        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            lblSilme.Visible = true;
        }
        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            lblSilme.Visible = false;
        }
        private void btnGuncelle_MouseLeave(object sender, EventArgs e)
        {
            lblGuncelleme.Visible = false;
        }
        private void btnGuncelle_MouseHover(object sender, EventArgs e)
        {
            lblGuncelleme.Visible = true;
        }
        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            //loginScreen.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtTCNo.Text != "" && (rbtnBay.Checked || rbtnBayan.Checked) && txtDogumYeri.Text != "" && txtTelefon.Text != "" && cbPoliklinik.Text != "")
            {
                string sCinsiyet = "";
                DBHASTANEEntities db = new DBHASTANEEntities();
                TBLHastalar hasta = new TBLHastalar();
                hasta.HastaAd = txtAd.Text;
                hasta.HastaSoyad = txtSoyad.Text;
                hasta.HastaTC = txtTCNo.Text;
                if (rbtnBay.Checked)
                {
                    sCinsiyet = "Bay";
                }
                else if (rbtnBayan.Checked)
                {
                    sCinsiyet = "Bayan";
                }
                hasta.HastaCinsiyet = sCinsiyet;
                hasta.HastaDogumYeri = txtDogumYeri.Text;
                hasta.HastaTelefon = txtTelefon.Text;
                hasta.Poliklinik = cbPoliklinik.SelectedItem.ToString();
                hasta.RandevuTarihi = dtpRandevuTarihi.Value.ToString();
                db.TBLHastalar.Add(hasta);
                db.SaveChanges();

                hastaListele();
                MessageBox.Show("Hasta Randevusu Eklendi!");
            }
            else
            {
                MessageBox.Show("Alanların doldurulması zorunludur!", "Uyarı!");
            }
        }
        private void hastaListele()
        {
            DBHASTANEEntities db = new DBHASTANEEntities();
            dataGridView1.DataSource = db.TBLHastalar.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            txtHastaID.Text = row.Cells["HastaID"].Value.ToString();
            txtAd.Text = row.Cells["HastaAd"].Value.ToString();
            txtSoyad.Text = row.Cells["HastaSoyad"].Value.ToString();
            txtTCNo.Text= row.Cells["HastaTC"].Value.ToString();
            if (row.Cells["HastaCinsiyet"].Value.ToString()=="Bay")
            {
                rbtnBay.Checked = true;
            }
            else
            {
                rbtnBayan.Checked = true;
            }
            txtDogumYeri.Text= row.Cells["HastaDogumYeri"].Value.ToString();
            txtTelefon.Text= row.Cells["HastaTelefon"].Value.ToString();
            cbPoliklinik.Text = row.Cells["Poliklinik"].Value.ToString();
            dtpRandevuTarihi.Value = DateTime.Parse(row.Cells["RandevuTarihi"].Value.ToString());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DBHASTANEEntities db = new DBHASTANEEntities();
            int id = Convert.ToInt32(txtHastaID.Text);
            var silinecek = db.TBLHastalar.Find(id);
            db.TBLHastalar.Remove(silinecek);
            db.SaveChanges();
            hastaListele();
            MessageBox.Show("Hasta Kaydı Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DBHASTANEEntities db = new DBHASTANEEntities();
            int id = Convert.ToInt32(txtHastaID.Text);
            var guncellenecek = db.TBLHastalar.Find(id);
            guncellenecek.HastaAd = txtAd.Text;
            guncellenecek.HastaSoyad = txtSoyad.Text;
            guncellenecek.HastaTC = txtTCNo.Text;
            if (rbtnBay.Checked)
            {
                guncellenecek.HastaCinsiyet = "Bay";
            }
            else if (rbtnBayan.Checked)
            {
                guncellenecek.HastaCinsiyet = "Bayan";
            }
            guncellenecek.HastaDogumYeri = txtDogumYeri.Text;
            guncellenecek.HastaTelefon = txtTelefon.Text;
            guncellenecek.Poliklinik = cbPoliklinik.SelectedItem.ToString();
            guncellenecek.RandevuTarihi = dtpRandevuTarihi.Value.ToString();
            db.SaveChanges();
            hastaListele();
            MessageBox.Show("Hasta Bilgileri Güncellendi");
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}