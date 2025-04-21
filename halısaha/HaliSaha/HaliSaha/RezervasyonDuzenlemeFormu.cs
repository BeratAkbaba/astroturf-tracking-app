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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HaliSaha
{
    public partial class RezervasyonDuzenlemeFormu : Form
    {
        public AnaForm afrm;
        public SahaFormu shfrm;
        public KramponFormu Krampon;
        public EldivenFormu Eldiven;
        public KaleciDuzenleFormu Kaleci;
        object sahafiyati;
        bool dolumu = false;

        public RezervasyonDuzenlemeFormu()
        {
            InitializeComponent();
            InitializeListView();
            //kalecitxt.Text = data;
            EkipmanPanel.Visible = false;
            EkipmanKapatPBox.Visible = false;
            chb_depozito.CheckedChanged += new EventHandler(chb_depozito_CheckedChanged);
        }

        #region Değişkenler ve Tanımlamalar
        #endregion

        #region Kullanıcı Tanımlı Olaylar

        //private void Kontrol()
        //{
        //    for (int k = 0; k < panel1.Controls.Count; k++)
        //    {
        //        if (panel1.Controls[k] is ComboBox)
        //        {
        //            if (panel1.Controls[k].Text != "")
        //            {
        //                dolumu = true;
        //            }
        //            else
        //            {
        //                dolumu = false;
        //                break;
        //            }
        //        }
        //    }
        //    if (!dolumu)
        //    {
        //        MessageBox.Show("Tüm alanların dolu olduğundan emin olun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    adisoyaditxt.Select();
        //}
        private void Temizle()
        {
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.TextBox textBox)
                {
                    textBox.Text = "";
                }
                else if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
            adisoyaditxt.Select(); 
        }
        private void OdemeDoldur()
        {
            DataTable MevcutTablo = new DataTable();
            string sorgu = "Select OdemeTuru from Odeme";
            MevcutTablo = VtIslem.VeriGetir(sorgu);
            cb_odeme.DataSource = MevcutTablo;
            cb_odeme.DisplayMember = "OdemeTuru";
        }
        private void SaatDoldur()
        {
            DataTable MevcutTablo = new DataTable();
            string sorgu = "Select Saat from SaatTablosu";
            MevcutTablo = VtIslem.VeriGetir(sorgu);
            cb_saat.DataSource = MevcutTablo;
            cb_saat.DisplayMember = "Saat";

        }
        private void MevcutlukDurumDoldur()
        {
            DataTable MevcutTablo = new DataTable();
            string sorgu = "Select MevcutlukDurumu from Mevcutluk";
            MevcutTablo = VtIslem.VeriGetir(sorgu);
            cb_rezdurumu.DataSource = MevcutTablo;
            cb_rezdurumu.DisplayMember = "MevcutlukDurumu";
        }


        private void KramponBtn_Click(object sender, EventArgs e)
        {
            Krampon = new KramponFormu();
            Krampon.rezerv = this;
            Krampon.ShowDialog();

        }

        private void EldivenBtn_Click(object sender, EventArgs e)
        {
            Eldiven = new EldivenFormu();
            Eldiven.rezerv = this;
            Eldiven.ShowDialog();
        }
        private void InitializeListView()
        {
            // ListView kontrolü ayarları
            EkipmanlarLV.View = View.Details;
            EkipmanlarLV.FullRowSelect = true;
            EkipmanlarLV.GridLines = true;

            // Sütun başlıklarını ekleme
            EkipmanlarLV.Columns.Add("Numara", 50);
            EkipmanlarLV.Columns.Add("Miktar", 50);
            EkipmanlarLV.Columns.Add("Fiyat", 50);
            EkipmanlarLV.Columns.Add("Marka", 50);
        }
        public void EkipmanEkle(ListViewItem selectedItem)
        {
            ListViewItem item = new ListViewItem(selectedItem.SubItems[0].Text);
            item.SubItems.Add(selectedItem.SubItems[1].Text);
            item.SubItems.Add(selectedItem.SubItems[2].Text);
            item.SubItems.Add(selectedItem.SubItems[3].Text);
            EkipmanlarLV.Items.Add(item);
        }
        #endregion

        #region Nesne Tanımlı Olaylar
        private void RezervasyonDuzenlemeFormu_Load(object sender, EventArgs e)
        {
            //Baslat();
            MevcutlukDurumDoldur();
            OdemeDoldur();
            SaatDoldur();
            adisoyaditxt.Select();
            EkipmanlarLV.Items.Clear();
        }
        //private void EkipmanTextBoxOlayi()
        //{
        //    string text = Ekipmanlar.Text;
        //    string[] lines = text.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        //    // DataGridView'e verileri ekleme
        //    foreach (string line in lines)
        //    {
        //        if (!string.IsNullOrWhiteSpace(line))
        //        {
        //            if (line.StartsWith("eldiven", StringComparison.OrdinalIgnoreCase))
        //            {
        //                // "eldiven" ile başlıyorsa ikiye ayırıp krampon ve eldiven kolonlarına ekle
        //                string[] data = line.Split(new[] { ' ' }, 2); // İlk boşluktan ayır
        //                if (data.Length == 2)
        //                {
        //                    dataGridView1.Rows.Add(null, data[1]);
        //                }
        //            }
        //            else
        //            {
        //                // Diğer durumlarda krampon kolonuna ekle
        //                dataGridView1.Rows.Add(line, null);
        //            }
        //        }
        //    }
        //}


        private void btn_Kaydet_Click(object sender, EventArgs e)
        b{
            try
            {
                // Ekipmanların Id'lerini ayırt et
                int? kramponId = null;
                int? eldivenId = null;

                foreach (ListViewItem item in EkipmanlarLV.Items)
                {
                    if (item.Tag != null && item.Tag.ToString() == "Krampon")
                    {
                        kramponId = int.Parse(item.SubItems[0].Text); // Id'yi aldığınızı varsayıyorum
                    }
                    else if (item.Tag != null && item.Tag.ToString() == "Eldiven")
                    {
                        eldivenId = int.Parse(item.SubItems[0].Text); // Id'yi aldığınızı varsayıyorum
                    }
                }
                string komut = "INSERT INTO Rezervasyon " +
                "(MusteriAdiSoyadi, Tarih, Saat, SahaId, KaleciId, KramponId, Eldivenid, ToplamFiyat, OdemeTuru, Depozito, RezervasyonDurumu) " +
                "VALUES (@MusteriAdiSoyadi, @Tarih, @Saat, @SahaId, @KaleciId, @KramponId, @Eldivenid, @ToplamFiyat, @OdemeTuru, @Depozito, @RezervasyonDurumu)";
                VtIslem.MusCmd.Parameters.Clear();
                VtIslem.MusCmd.Parameters.AddWithValue("@MusteriAdiSoyadi", adisoyaditxt.Text);
                VtIslem.MusCmd.Parameters.AddWithValue("@Tarih", tarihdtp.Value.Date.ToString("yyyy-MM-dd"));
                VtIslem.MusCmd.Parameters.AddWithValue("@Saat", cb_saat.SelectedValue.ToString());
                VtIslem.MusCmd.Parameters.AddWithValue("@SahaId", cb_saha.Text);
                VtIslem.MusCmd.Parameters.AddWithValue("@KaleciId", kalecitxt.Text);
                VtIslem.MusCmd.Parameters.AddWithValue("@KramponId", EkipmanlarLV.Items);
                VtIslem.MusCmd.Parameters.AddWithValue("@Eldivenid", EkipmanlarLV.Items);
                VtIslem.MusCmd.Parameters.AddWithValue("@ToplamFiyat", decimal.Parse(toplamtutartxt.Text));
                VtIslem.MusCmd.Parameters.AddWithValue("@OdemeTuru", cb_odeme.SelectedItem);
                VtIslem.MusCmd.Parameters.AddWithValue("@Depozito", decimal.Parse(depozitotxt.Text));
                VtIslem.MusCmd.Parameters.AddWithValue("@RezervasyonDurumu", cb_rezdurumu.Text);
                VtIslem.KomutCalistir(komut);
                if (MusteriParametre.IslemDurumu > -1)
                {
                    MessageBox.Show("Yeni Müşteri Oluşturuldu", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Kaleci = new KaleciDuzenleFormu();
            Kaleci.rezerv = this;
            Kaleci.KaleciFormSplitC.Panel1Collapsed = true;
            Kaleci.Size= new Size(600,400);
            Kaleci.ShowDialog();
        }


        private void EkipmanAcPBox_Click_1(object sender, EventArgs e)
        {
            EkipmanPanel.Visible = true;
            EkipmanKapatPBox.Visible = true;
            EkipmanAcPBox.Visible = false;
        }

        private void EkipmanKapatPBox_Click(object sender, EventArgs e)
        {
            EkipmanPanel.Visible = false;
            EkipmanKapatPBox.Visible = false;
            EkipmanAcPBox.Visible = true;
        }

        private void btn_IptalEt_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void chb_depozito_CheckedChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    if (chb_depozito.Checked)
            //    {
            //        row.Cells[7].Style.BackColor = Color.Green; // Checkbox işaretliyse hücre yeşil olur
            //        row.Cells[7].Style.ForeColor = Color.White; // İsterseniz metin rengini de değiştirebilirsiniz
            //    }
            //    else
            //    {
            //        row.Cells[7].Style.BackColor = Color.LightCoral; // Checkbox işaretli değilse hücre açık kırmızı olur
            //        row.Cells[7].Style.ForeColor = Color.Black; // İsterseniz metin rengini de değiştirebilirsiniz
            //    }
            //}
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SilTSMI_Click(object sender, EventArgs e)
        {
            if (EkipmanlarLV.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in EkipmanlarLV.SelectedItems)
                {
                    EkipmanlarLV.Items.Remove(selectedItem);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }
        #endregion
        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string komut = "Update Rezervasyon Set Tarih='" + tarihdtp.Text + "', Saat='" + cb_saat.Text +
                    "', SahaId='" + cb_saha.Text + "', KaleciId='" + kalecitxt.Text +
                    "', KramponId='" + EkipmanlarLV.Text + "' , Eldivenid='" + EkipmanlarLV.Text + "'" +
                    ", ToplamFiyat='" + toplamtutartxt.Text + "', OdemeTuru='" + cb_odeme.Text + "' " +
                    ", Depozito='" + depozitotxt.Text + "', RezervasyonDurumu='" + cb_rezdurumu.Text + "'  Where MusteriAdiSoyadi='" + adisoyaditxt.Text + "'";
                VtIslem.KomutCalistir(komut);
                MessageBox.Show("Müşteri Verileri \nGüncellendi!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //private void cb_saha_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (cb_saha.SelectedIndex > 0)
        //    {
        //        String sorgu = "Select Fiyat from SahaBilgisi where SahaId='" + cb_saha.SelectedIndex + "'";
        //        sahafiyati = Yardimci.VtIslem.VeriGetir(sorgu);
        //            try
        //            {
        //                toplamtutartxt.Text = sahafiyati.ToString();
        //            }
        //            catch (FormatException ex)
        //            {
        //                MessageBox.Show("Fiyat dönüştürülürken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Lütfen bir saha seçiniz", "Bilgi",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void cb_saha_DropDownClosed(object sender, EventArgs e)
        {
            if (cb_saha.SelectedIndex > 0)
            {
                String sorgu = "Select Fiyat from SahaBilgisi where SahaId='" + cb_saha.SelectedIndex + "'";
                sahafiyati = Yardimci.VtIslem.VeriGetir(sorgu);
                try
                {
                    toplamtutartxt.Text = sahafiyati.ToString();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Fiyat dönüştürülürken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir saha seçiniz", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
