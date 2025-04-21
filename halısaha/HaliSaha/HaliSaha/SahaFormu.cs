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
using static HaliSaha.Yardimci;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HaliSaha
{
    public partial class SahaFormu : Form

    {
        
        public SahaFormu()
        {
            InitializeComponent();

        }

        #region Değişkenler ve Tanımlamalar        
        public AnaForm afrm;
        public RezervasyonDuzenlemeFormu Rezervasyon;
        public SahaFiyatlandırmaFormu SahaF;
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void VeriDoldur(string tabloAdi)
        {
            string sorgu = $"SELECT MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid, ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu FROM {tabloAdi}";
            RezervasyonDgv.DataSource = Yardimci.VtIslem.VeriGetir(sorgu);
        }
        private void BaslikGoster()
        {
            RezervasyonDgv.Columns[0].HeaderText = "Adı";
            RezervasyonDgv.Columns[0].Width = 100;
            RezervasyonDgv.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[1].HeaderText = "Tarih";
            RezervasyonDgv.Columns[1].Width = 80;
            RezervasyonDgv.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[2].HeaderText = "Saat";
            RezervasyonDgv.Columns[2].Width = 70;
            RezervasyonDgv.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[3].HeaderText = "Saha Numarası";
            RezervasyonDgv.Columns[3].Width = 60;
            RezervasyonDgv.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[4].HeaderText = "Kaleci";
            RezervasyonDgv.Columns[4].Width = 90;
            RezervasyonDgv.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[5].HeaderText = "Krampon";
            RezervasyonDgv.Columns[5].Width = 100;
            RezervasyonDgv.Columns[5].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[6].HeaderText = "Eldiven";
            RezervasyonDgv.Columns[6].Width = 100;
            RezervasyonDgv.Columns[6].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[7].HeaderText = "Tutar";
            RezervasyonDgv.Columns[7].Width = 60;
            RezervasyonDgv.Columns[7].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[8].HeaderText = "Ödeme Türü";
            RezervasyonDgv.Columns[8].Width = 80;
            RezervasyonDgv.Columns[8].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[9].HeaderText = "Depozito";
            RezervasyonDgv.Columns[9].Width = 60;
            RezervasyonDgv.Columns[9].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            RezervasyonDgv.Columns[10].HeaderText = "Durum";
            RezervasyonDgv.Columns[10].Width = 90;
            RezervasyonDgv.Columns[10].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
        }
        private void Baslat()
        {
            VeriDoldur("Rezervasyon");
            BaslikGoster();
        }
        #endregion
        private void SahaFormu_Load(object sender, EventArgs e)
        {
            Baslat();
            RezervasyonCbox.SelectedIndex = 1;
            SahaCBox.SelectedIndex = 0;
            Timer timer = new Timer();
            timer.Interval = 360000; // 1 saatte bir çalıştırdım.
            timer.Tick += new EventHandler(ZamanlayiciRezervasyon_Tick);
            timer.Start();
        }
        private void ZamanlayiciRezervasyon_Tick(object sender, EventArgs e)
        {
            GeçmişRezervasyonlarıSil();
        }

        #region Nesne Tanımlı Olaylar
        private void GeçmişRezervasyonlarıSil()
        {
            string sorgu = @"
                DECLARE @SimdikiZaman DATETIME = GETDATE();

                -- Geçmiş rezervasyonları RezervasyonSil tablosuna ekle
                INSERT INTO RezervasyonSil (MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid, ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu)
                SELECT MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid, ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu
                FROM Rezervasyon
                WHERE Tarih < @SimdikiZaman;

                -- Geçmiş rezervasyonları Rezervasyon tablosundan sil
                DELETE FROM Rezervasyon
                WHERE Tarih < @SimdikiZaman;";

            using (SqlConnection baglanti = new SqlConnection(VtBaglanti.VtAdres))
            {
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Rezervasyon = new RezervasyonDuzenlemeFormu();
                Rezervasyon.shfrm = this;
                Rezervasyon.BackColor= Color.FromArgb(175, 255, 175);
                Rezervasyon.adisoyaditxt.Text = RezervasyonDgv.CurrentRow.Cells[0].Value.ToString();
                Rezervasyon.tarihdtp.Text = RezervasyonDgv.CurrentRow.Cells[1].Value.ToString();
                Rezervasyon.cb_saat.Text = RezervasyonDgv.CurrentRow.Cells[2].Value.ToString();
                Rezervasyon.cb_saha.Text = RezervasyonDgv.CurrentRow.Cells[3].Value.ToString();
                Rezervasyon.kalecitxt.Text = RezervasyonDgv.CurrentRow.Cells[4].Value.ToString();
                Rezervasyon.EkipmanlarLV.Text = RezervasyonDgv.CurrentRow.Cells[5].Value.ToString();
                Rezervasyon.EkipmanlarLV.Text = RezervasyonDgv.CurrentRow.Cells[6].Value.ToString();
                Rezervasyon.toplamtutartxt.Text = RezervasyonDgv.CurrentRow.Cells[7].Value.ToString();
                Rezervasyon.cb_odeme.Text = RezervasyonDgv.CurrentRow.Cells[8].Value.ToString();
                Rezervasyon.depozitotxt.Text = RezervasyonDgv.CurrentRow.Cells[9].Value.ToString();
                Rezervasyon.cb_rezdurumu.Text = RezervasyonDgv.CurrentRow.Cells[10].Value.ToString();
                Rezervasyon.adisoyaditxt.Enabled = false;
                Rezervasyon.EkleLbl.Visible = false;
                Rezervasyon.GuncelleLbl.Visible = true;
                Rezervasyon.btn_Kaydet.Visible = false;
                Rezervasyon.GuncelleBtn.Visible = true;
                Rezervasyon.ShowDialog();
                VeriDoldur("Rezervasyon");
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RezervasyonCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (RezervasyonCbox.SelectedIndex == 1) // Güncel rezervasyonlar
                {
                    if (SahaCBox.SelectedIndex == 0) // Tüm sahalar için
                    {
                        VeriDoldur("Rezervasyon");
                    }
                    else // Belirli bir saha için
                    {
                        string sorgu = "Select MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid," +
                                       " ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu " +
                                       "From Rezervasyon Where SahaId = " + SahaCBox.SelectedIndex;
                        RezervasyonDgv.DataSource = VtIslem.VeriGetir(sorgu);
                    }
                }
                else if (RezervasyonCbox.SelectedIndex == 2) // Geçmiş rezervasyonlar
                {
                    if (SahaCBox.SelectedIndex == 0) // Tüm sahalar için
                    {
                        VeriDoldur("RezervasyonSil");
                    }
                    else // Belirli bir saha için
                    {
                        string sorgu = "Select MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid," +
                                       " ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu " +
                                       "From RezervasyonSil Where SahaId = " + SahaCBox.SelectedIndex;
                        RezervasyonDgv.DataSource = VtIslem.VeriGetir(sorgu);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SahaCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SahaCBox.SelectedIndex == 0) // Eğer tüm sahalar seçiliyse
            {
                if (RezervasyonCbox.SelectedIndex == 1) // Eğer güncel rezervasyonlar seçiliyse
                {
                    // Tüm sahalar için güncel rezervasyonları getir
                    VeriDoldur("Rezervasyon");
                }
                else if (RezervasyonCbox.SelectedIndex == 2) // Eğer geçmiş rezervasyonlar seçiliyse
                {
                    // Tüm sahalar için geçmiş rezervasyonları getir
                    VeriDoldur("RezervasyonSil");
                }
            }
            else // Belirli bir saha seçiliyse
            {
                if (RezervasyonCbox.SelectedIndex == 1) // Eğer güncel rezervasyonlar seçiliyse
                {
                    // Seçilen sahaya göre güncel rezervasyonları getir
                    string sorgu = "SELECT MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid," +
                                   " ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu " +
                                   "FROM Rezervasyon WHERE SahaId = " + SahaCBox.SelectedIndex;
                    RezervasyonDgv.DataSource = VtIslem.VeriGetir(sorgu);
                }
                else if (RezervasyonCbox.SelectedIndex == 2) // Eğer geçmiş rezervasyonlar seçiliyse
                {
                    // Seçilen sahaya göre geçmiş rezervasyonları getir
                    string sorgu = "SELECT MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid," +
                                   " ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu " +
                                   "FROM RezervasyonSil WHERE SahaId = " + SahaCBox.SelectedIndex;
                    RezervasyonDgv.DataSource = VtIslem.VeriGetir(sorgu);
                }
            }
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            BilgiLbl.Visible = false;
            BilgiPBox.Visible = false;
            SoruIsareti.Visible = true;
            SahaF = new SahaFiyatlandırmaFormu();
            SahaF.shfrm = this;
            SahaF.ShowDialog();
        }

        private void SoruIsareti_Click(object sender, EventArgs e)
        {
            BilgiLbl.Visible = true;
            BilgiPBox.Visible = true;
            SoruIsareti.Visible = false;
        }
    }
}
