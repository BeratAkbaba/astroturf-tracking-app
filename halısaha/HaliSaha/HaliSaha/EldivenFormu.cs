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
    public partial class EldivenFormu : Form
    {
        public EldivenFormu()
        {
            InitializeComponent();
        }
        public RezervasyonDuzenlemeFormu rezerv;
        #region Değişkenler ve Tanımlamalar        

        static string VtAdres = "Data Source=localhost;Initial Catalog=HalisahaVT; User Id=sa;Password=mmyo;";
        SqlConnection MusConn = new SqlConnection(VtAdres);
        SqlDataAdapter MusAdp;
        SqlCommand MusCmd = new SqlCommand();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        #endregion

        #region Nesne Tanımlı Olaylar
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

        private void EldivenFormu_Load(object sender, EventArgs e)
        {
            EldivenLV.View = View.Details;
            EldivenLV.Columns.Add("Miktar", 50);
            EldivenLV.Columns.Add("Fiyat", 50);
            EldivenLV.Columns.Add("Marka", 50);

            // Veritabanından veri çekme
            string sorgu = "SELECT  Miktar, Fiyat, Marka FROM Eldiven";
            DataTable dt = VtIslem.VeriGetir(sorgu);

            // Verileri ListView'e ekleme
            ListViewOlayi(dt);
        }
        
        private void ListViewOlayi(DataTable dt)
        {
            EldivenLV.Items.Clear(); // Önceki verileri temizle

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["Miktar"].ToString());
                decimal fiyat = Convert.ToDecimal(row["Fiyat"]);
                item.SubItems.Add(fiyat.ToString("F0"));
                item.SubItems.Add(row["Marka"].ToString());
                EldivenLV.Items.Add(item);
            }
        }
        #endregion

        private void ArtiBtn_Click(object sender, EventArgs e)
        {
            if (EldivenLV.SelectedItems.Count > 0)
            {
                string miktarStr = EldivenLV.SelectedItems[0].SubItems[0].Text;
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
            if (SayiTBox.Text == "0")
            {
                EkleBtn.Enabled = false;
            }
            else
            {
                EkleBtn.Enabled = true;
            }
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (EldivenLV.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = EldivenLV.SelectedItems[0];
                string kramponNumarasi = selectedItem.SubItems[0].Text;
                string miktar = SayiTBox.Text;
                string fiyat = selectedItem.SubItems[1].Text;
                string marka = selectedItem.SubItems[2].Text;
                ListViewItem newItem = new ListViewItem("");
                newItem.SubItems.Add(miktar);
                newItem.SubItems.Add(fiyat);
                newItem.SubItems.Add(marka);
                rezerv.EkipmanlarLV.Items.Add(newItem);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen eklemek için bir eldiven seçin.");
            }
        }

        private void IptalEtBtn_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void EldivenLV_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SayiTBox.Enabled = true;
            ArtiBtn.Enabled = true;
            EksiBtn.Enabled = true;
        }
    }
}
