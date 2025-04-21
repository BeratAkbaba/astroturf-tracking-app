using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HaliSaha.Yardimci;

namespace HaliSaha
{
    public partial class SahaFiyatlandırmaFormu : Form
    {
        public SahaFiyatlandırmaFormu()
        {
            InitializeComponent();
        }
        public SahaFormu shfrm;
        bool dolumu = false;
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
            SahaCBox.Select();
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
            SahaCBox.Select();
        }
        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Kontrol();
                if (dolumu)
                {
                    string komut = "Update SahaBilgisi Set Fiyat='" + FiyatTBox.Text +
                        "'  Where SahaId='" + SahaCBox.SelectedIndex + "'";
                    VtIslem.KomutCalistir(komut);
                    MessageBox.Show("Saha Fiyatlandırması \nGüncellendi!", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Temizle();
                    this.Close();
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

        private void SahaFiyatlandırmaFormu_Load(object sender, EventArgs e)
        {
            SahaCBox.SelectedIndex = 0;
        }
    }
}
