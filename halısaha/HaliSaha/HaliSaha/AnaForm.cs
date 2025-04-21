using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSaha
{
    public partial class AnaForm : Form
    {
        public KullaniciGirisFormu oturum;
        public RezervasyonDuzenlemeFormu Rezervasyon;
        public SahaFormu Saha;
        public EkipmanBilgisi Ekipman;
        public KaleciDuzenleFormu Kaleci;
        public KullaniciGirisFormu kgfrm;
        public YeniKullaniciForm Yeni;
        public AnaForm()
        {
            InitializeComponent();
            oturum = new KullaniciGirisFormu();
            oturum.afrm = this;
            oturum.ShowDialog();
        }

        #region Değişkenler ve Tanımlamalar
        public int sahaNumarasi;
        #endregion


        #region Kullanıcı Tanımlı Olaylar
        private void VeriDoldur()
        {
            string sorgu = "Select  MusteriAdiSoyadi, SahaId, RezervasyonDurumu From Rezervasyon";
            DurumDgv.DataSource = Yardimci.VtIslem.VeriGetir(sorgu);
        }

        private void BaslikGoster()
        {
            DurumDgv.Columns[0].HeaderText = "Adı";
            DurumDgv.Columns[0].Width = 100;
            DurumDgv.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            DurumDgv.Columns[1].HeaderText = "Saha Numarası";
            DurumDgv.Columns[1].Width = 90;
            DurumDgv.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            DurumDgv.Columns[2].HeaderText = "Durum";
            DurumDgv.Columns[2].Width = 90;
            DurumDgv.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
        }
        private void Baslat()
        {
            VeriDoldur();
            BaslikGoster();
        }
        
        #endregion
        #region Nesne Tanımlı Olaylar
        private void AnaForm_Load(object sender, EventArgs e)
        {
            Baslat();
        }

        private void rezervasyonDuzenleTSMI_Click(object sender, EventArgs e)
        {
            Rezervasyon = new RezervasyonDuzenlemeFormu();
            Rezervasyon.afrm = this;
            Rezervasyon.ShowDialog();
        }
        private void sahaDurumuTSMI_Click(object sender, EventArgs e)
        {
            Saha = new SahaFormu();
            Saha.afrm = this;
            Saha.ShowDialog();
        }

        private void yeniÜrünGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ekipman= new EkipmanBilgisi();
            Ekipman.afrm= this;
            Ekipman.ShowDialog();
        }
        private void KalecilerTSMI_Click_1(object sender, EventArgs e)
        {
            Kaleci = new KaleciDuzenleFormu();
            Kaleci.afrm = this;
            Kaleci.ShowDialog();
        }
        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \nSonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Application.Exit();
        }





        #endregion

        private void ekipmanBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniKullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yeni = new YeniKullaniciForm();
            Yeni.afrm = this;
            Yeni.ShowDialog();
        }
    }
}
