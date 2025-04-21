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
using static System.Net.Mime.MediaTypeNames;

namespace HaliSaha
{
    public partial class EkipmanBilgisi : Form
    {
        public EkipmanBilgisi()
        {
            InitializeComponent();
            NumaraLbl.Visible = false;
            NumaraTBox.Visible = false;
        }
        public AnaForm afrm;
        #region Değişkenler ve Tanımlamalar
        bool dolumu = false;
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void Kontrol()
        {
            for (int k = 0; k < Controls.Count; k++)
            {
                if (Controls[k] is TextBox)
                {
                    if (Controls[k].Text.Trim() != "")
                        dolumu = true;
                    else
                    {
                        dolumu = false;
                        break;
                    }
                }
            }
            urunAdiCBox.Select();
        }
        private void Temizle()
        {
            for (int k = 0; k < Controls.Count; k++)
            {
                if (Controls[k] is TextBox)
                {
                    Controls[k].Text = "";
                }
            }
            MarkaCBox.SelectedIndex = 0;
            urunAdiCBox.SelectedIndex = 0;
            urunAdiCBox.Select();
        }
        private void ComboBoxDoldur(ComboBox comboBox, string sorgu, string displayMember)
        {
            DataTable tablo = new DataTable();
            tablo = VtIslem.VeriGetir(sorgu);
            comboBox.DataSource = tablo;
            comboBox.DisplayMember = displayMember;
        }

        private void KramponDoldur()
        {
            string sorgu = "SELECT DISTINCT Marka FROM Eldiven";
            ComboBoxDoldur(MarkaCBox, sorgu, "Marka");
        }

        private void EldivenDoldur()
        {
            string sorgu = "SELECT DISTINCT Marka FROM Krampon";
            ComboBoxDoldur(MarkaCBox, sorgu, "Marka");
        }

        #endregion

        #region Nesne Tanımlı Olaylar


        #endregion

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            String ekipman= urunAdiCBox.SelectedValue.ToString();
            string komut;
            try
            {
                Kontrol();
                if (dolumu)
                {
                    if (ekipman == "Eldiven")
                    {
                        komut = "Insert Into Eldiven (Miktar, Fiyat, Marka) Values (@Miktar, @Fiyat, @Marka)";
                        VtIslem.MusCmd.Parameters.Clear();
                        VtIslem.MusCmd.Parameters.AddWithValue("@Miktar", MiktarTBox.Text);
                        VtIslem.MusCmd.Parameters.AddWithValue("@Fiyat", FiyatTBox.Text);
                        VtIslem.MusCmd.Parameters.AddWithValue("@Marka", MarkaCBox.Text);
                        VtIslem.KomutCalistir(komut);
                        if (MusteriParametre.IslemDurumu > -1)
                        {
                            MessageBox.Show("Eldiven Eklendi", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                    }
                    if (ekipman == "Krampon")
                    {
                        NumaraLbl.Visible = true;
                        NumaraTBox.Visible = true;
                        komut = "Insert Into Krampon (KramponNumarasi, Miktar, Fiyat, Marka) Values (@KramponNumarasi, @Miktar, @Fiyat, @Marka)";
                        VtIslem.MusCmd.Parameters.Clear();
                        VtIslem.MusCmd.Parameters.AddWithValue("@KramponNumarasi", NumaraTBox.Text);
                        VtIslem.MusCmd.Parameters.AddWithValue("@Miktar", MiktarTBox.Text);
                        VtIslem.MusCmd.Parameters.AddWithValue("@Fiyat", FiyatTBox.Text);
                        VtIslem.MusCmd.Parameters.AddWithValue("@Marka", MarkaCBox.Text);
                        VtIslem.KomutCalistir(komut);
                        if (MusteriParametre.IslemDurumu > -1)
                        {
                            MessageBox.Show("Krampon Eklendi", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Temizle();
                        }
                    }
                    
                }
                else
                {
                    MessageBox.Show("Veri Alanlarını \nKontrol Ediniz!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Kontrol();
            //    if (dolumu)
            //    {
            //        string komut = "Update Kimlik Set FirmaBilgisi='" + tbFirmaBilgisi.Text +
            //            "', YetkiliAdi='" + tbYetkiliAd.Text + "', YetkiliSoyadi='" + tbYetkiliSoyad.Text +
            //            "', FirmaAdresi='" + tbFirmaAdresi.Text + "', TelefonNo='" + tbTelefonNo.Text +
            //            "'  Where MusteriNo='" + tbMusteriNo.Text + "'";
            //        VtIslem.KomutCalistir(komut);
            //        MessageBox.Show("Müşteri Verileri \nGüncellendi!", "Bilgi",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Temizle();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Veri Alanlarını \nKontrol Ediniz!", "Bilgi",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch (Exception msg)
            //{
            //    MessageBox.Show(msg.Message, "Bilgi",
            //            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Seçili Olan Kullanici \nSilinsin mi?", "Onay",
            //    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    string Komut = "Delete from Kullanici Where KullaniciAdi=@KullaniciAdi";
            //    VtIslem.MusCmd.Parameters.Clear();
            //    VtIslem.MusCmd.Parameters.AddWithValue("@KullaniciAdi",
            //        dgvKullanListe.CurrentRow.Cells[0].Value.ToString());
            //    VtIslem.KomutCalistir(Komut);
            //    VeriDoldur();
            //}
        }

        private void EkipmanBilgisi_Load(object sender, EventArgs e)
        {
            KramponDoldur();
            EldivenDoldur();
        }
    }
}
