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
    public partial class KramponFormu : Form
    {
        public KramponFormu()
        {
            InitializeComponent();
        }
        public RezervasyonDuzenlemeFormu rezerv;
        #region Değişkenler ve Tanımlamalar
        bool dolumu = false;
        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void Kontrol()
        {
            for (int k = 0; k < Controls.Count; k++)
            {
                if (Controls[k] is System.Windows.Forms.TextBox)
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
        }
        private void Temizle()
        {
            foreach (Control control in Controls)
            {
                if (control is System.Windows.Forms.ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                }
            }
            SayiTBox.Enabled = false;
            ArtiBtn.Enabled = false;
            EksiBtn.Enabled = false;
        }

        #endregion

        #region Nesne Tanımlı Olaylar


        #endregion

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (KramponLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = KramponLV.SelectedItems[0];
                string kramponNumarasi = selectedItem.SubItems[0].Text;
                string miktar = SayiTBox.Text;
                string fiyat = selectedItem.SubItems[2].Text;
                string marka = selectedItem.SubItems[3].Text;
                ListViewItem newItem = new ListViewItem(kramponNumarasi);
                newItem.SubItems.Add(miktar);
                newItem.SubItems.Add(fiyat);
                newItem.SubItems.Add(marka);
                rezerv.EkipmanlarLV.Items.Add(newItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen eklemek için bir krampon seçin.");
            }
            //try
            //{
            //    Kontrol();
            //    if (dolumu)
            //    {
            //        int secilenKramponId = (int)KramponListesi.SelectedValue;
            //        string komut = "INSERT INTO Krampon (KramponId) VALUES (@KramponId)";
            //        VtIslem.MusCmd.Parameters.Clear();
            //        VtIslem.MusCmd.Parameters.AddWithValue("@KramponId", secilenKramponId);
            //        VtIslem.KomutCalistir(komut);
            //        Temizle();
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

        private void KramponFormu_Load(object sender, EventArgs e)
        {
            KramponLV.View = View.Details;
            KramponLV.Columns.Add("Numara", 50);
            KramponLV.Columns.Add("Miktar", 50);
            KramponLV.Columns.Add("Fiyat", 50);
            KramponLV.Columns.Add("Marka", 50);

            // Veritabanından veri çekme
            string sorgu = "SELECT KramponNumarasi, Miktar, Fiyat, Marka FROM Krampon";
            DataTable dt = VtIslem.VeriGetir(sorgu);

            // Verileri ListView'e ekleme
            ListViewOlayi(dt);

        }
        private void ListViewOlayi(DataTable dt)
        {
            KramponLV.Items.Clear(); // Önceki verileri temizle

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["KramponNumarasi"].ToString());
                item.SubItems.Add(row["Miktar"].ToString());
                decimal fiyat = Convert.ToDecimal(row["Fiyat"]);
                item.SubItems.Add(fiyat.ToString("F0"));
                item.SubItems.Add(row["Marka"].ToString());
                KramponLV.Items.Add(item);
            }
        }

        private void ArtiBtn_Click(object sender, EventArgs e)
        {
            if (KramponLV.SelectedItems.Count > 0)
            {
                string miktarStr = KramponLV.SelectedItems[0].SubItems[1].Text;
                int miktar;
                if (int.TryParse(miktarStr, out miktar))
                {
                    // Artırma işlemi
                    int currentValue = 0;
                    if (int.TryParse(SayiTBox.Text, out currentValue))
                    {
                        // Seçilen satırın miktar sayısına kadar artır
                        if (currentValue < miktar)
                        {
                            currentValue++;
                            SayiTBox.Text = currentValue.ToString();
                        }
                    }
                }
                EkleBtn.Enabled = true;
            }
        }

        private void EksiBtn_Click(object sender, EventArgs e)
        {
            int currentValue = 0;
            if (int.TryParse(SayiTBox.Text, out currentValue))
            {
                // Eğer değer 0'dan büyükse azalt
                if (currentValue > 0)
                {
                    currentValue--;
                }
                SayiTBox.Text = currentValue.ToString();
            }
            if (SayiTBox.Text=="0")
            {
                EkleBtn.Enabled = false;
            }
            else
            {
                EkleBtn.Enabled = true;
            }
        }

        private void KramponLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            ArtiBtn.Enabled = true;
            EksiBtn.Enabled = true;
            SayiTBox.Enabled = true;
        }

        private void IptalEtBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
