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

namespace HaliSaha
{
    public partial class KaleciDuzenleFormu : Form
    {
        public KaleciDuzenleFormu()
        {
            InitializeComponent();
            GuncelleBtn.Visible = false;
        }
        public AnaForm afrm;
        public RezervasyonDuzenlemeFormu rezerv;
        bool dolumu = false;
        public int kalecifiyati;
        #region Değişkenler ve Tanımlamalar        

        static string VtAdres = "Data Source=localhost;Initial Catalog=HalisahaVT; User Id=sa;Password=mmyo;";
        SqlConnection MusConn = new SqlConnection(VtAdres);
        SqlDataAdapter MusAdp;
        SqlCommand MusCmd = new SqlCommand();

        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void Kontrol()
        {
            for (int k = 0; k < KPanel.Controls.Count; k++)
            {
                if (KPanel.Controls[k] is TextBox)
                {
                    if (KPanel.Controls[k].Text.Trim() != "")
                    {
                        dolumu = true;
                    }
                    else
                    {
                        dolumu = false;
                        break;
                    }
                }
            }
            if (!dolumu)
            {
                MessageBox.Show("Tüm alanların dolu olduğundan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            adTBox.Select();
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
            MevcutCBox.SelectedIndex = 0;
            adTBox.Select();
        }
        private void MevcutlukDoldur()
        {
            DataTable MevcutTablo = new DataTable();
            string sorgu = "Select MevcutlukDurumu from Mevcutluk";
            MevcutTablo = VtIslem.VeriGetir(sorgu);
            MevcutCBox.DataSource = MevcutTablo;
            MevcutCBox.DisplayMember = "MevcutlukDurumu";
        }

        private void VeriDoldur()
        {
            string sorgu = "Select KaleciAdiSoyadi, Yas, TelefonNo, " +
                "MevcutlukDurumu, Fiyat  from KaleciEkle";
            dataGridView1.DataSource = VtIslem.VeriGetir(sorgu);
        }

        private void BaslikGoster()
        {
            dataGridView1.Columns[0].HeaderText = "Ad";
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[1].HeaderText = "Yas";
            dataGridView1.Columns[1].Width = 40;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].HeaderText = "Telefon No";
            dataGridView1.Columns[2].Width = 90;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].HeaderText = "Durum";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].HeaderText = "Fiyat";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N0";
        }
        private void Baslat()
        {
            MevcutlukDoldur();
            VeriDoldur();
            BaslikGoster();
        }
        #endregion

        #region Nesne Tanımlı Olaylar
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Kontrol();
                if (dolumu)
                {
                    string komut = "Insert Into KaleciEkle (KaleciAdiSoyadi,Yas, TelefonNo,MevcutlukDurumu, Fiyat) Values (@KaleciAdiSoyadi,@Yas, @TelefonNo,@MevcutlukDurumu, @Fiyat)";
                    VtIslem.MusCmd.Parameters.Clear();
                    VtIslem.MusCmd.Parameters.AddWithValue("@KaleciAdiSoyadi", adTBox.Text);
                    VtIslem.MusCmd.Parameters.AddWithValue("@Yas", YasTBox.Text);
                    VtIslem.MusCmd.Parameters.AddWithValue("@TelefonNo", TelTBox.Text);
                    VtIslem.MusCmd.Parameters.AddWithValue("@MevcutlukDurumu", MevcutCBox.Text);
                    VtIslem.MusCmd.Parameters.AddWithValue("@Fiyat", FiyatTBox.Text);
                    VtIslem.KomutCalistir(komut);
                    if (MusteriParametre.IslemDurumu > -1)
                    {
                        MessageBox.Show("Kayıt Başarılı", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        VeriDoldur();
                        Temizle();
                    }

                    else
                    {
                        MessageBox.Show("Veri Alanlarını \nKontrol Ediniz!", "Bilgi",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuncelleBtn.Visible = true;
            kaydetBtn.Visible = false;
            adTBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            YasTBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            TelTBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            MevcutCBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Olan Kaleci \nSilinsin mi?", "Onay",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    string ekleKomutu = "INSERT INTO KaleciSil (KaleciAdiSoyadi, Yas, TelefonNo, MevcutlukDurumu, Fiyat) VALUES (@KaleciAdiSoyadi, @Yas, @TelefonNo, @MevcutlukDurumu, @Fiyat)";
                    VtIslem.MusCmd.Parameters.Clear();
                    VtIslem.MusCmd.Parameters.AddWithValue("@KaleciAdiSoyadi", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    VtIslem.MusCmd.Parameters.AddWithValue("@Yas", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    VtIslem.MusCmd.Parameters.AddWithValue("@TelefonNo", dataGridView1.CurrentRow.Cells[2].Value.ToString());
                    VtIslem.MusCmd.Parameters.AddWithValue("@MevcutlukDurumu", dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    VtIslem.MusCmd.Parameters.AddWithValue("@Fiyat", dataGridView1.CurrentRow.Cells[4].Value.ToString());
                    VtIslem.KomutCalistir(ekleKomutu);

                    // KaleciEkle tablosundan kaleci bilgilerini sil
                    string silKomutu = "DELETE FROM KaleciEkle WHERE TelefonNo=@TelefonNo";
                    VtIslem.MusCmd.Parameters.Clear();
                    VtIslem.MusCmd.Parameters.AddWithValue("@TelefonNo", dataGridView1.CurrentRow.Cells["TelefonNo"].Value.ToString());
                    VtIslem.KomutCalistir(silKomutu);

                    VeriDoldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KaleciDuzenleFormu_Load(object sender, EventArgs e)
        {
            Baslat();
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            Temizle();
            if (GuncelleBtn.Visible == true)
            {
                GuncelleBtn.Visible = false;
                kaydetBtn.Visible = true;
            }

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //kalecifiyati = Int16.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                rezerv.kalecitxt.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen eklemek için bir eldiven seçin.");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Kontrol();
                if (dolumu)
                {
                    string komut = "Update KaleciEkle Set KaleciAdiSoyadi='" + adTBox.Text +
                        "',Yas='" + YasTBox.Text + "', TelefonNo='" + TelTBox.Text + "', MevcutlukDurumu='" + MevcutCBox.Text + "' Where TelefonNo='" + TelTBox.Text + "' ";
                    VtIslem.KomutCalistir(komut);
                    MessageBox.Show("Veriler Güncellendi!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VeriDoldur();
                    Temizle();
                    kaydetBtn.Visible = true;
                    GuncelleBtn.Visible = false;
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


        #endregion

        private void KaleciDuzenleFormu_Load_1(object sender, EventArgs e)
        {
            Baslat();
        }

        private void KPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MevcutCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

