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
//using static HaliSaha.Yardımcı;

namespace HaliSaha
{
    public partial class KullaniciGirisFormu : Form
    {
        
        public KullaniciGirisFormu()
        {
            InitializeComponent();
        }

        #region Değişkenler ve Tanımlamalar        
        public AnaForm afrm;
        public SifremiUnuttum Sifrem;
        public YeniKullaniciForm Kullanicilar;

        DataTable KullaniciTablo;
        bool yokmu = false;

        #endregion

        #region Kullanıcı Tanımlı Olaylar
        private void VeriDoldur()
        {
            KullaniciTablo= new DataTable();
            string sorgu = "Select KullaniciAdi, KullaniciSifresi From Kullanici";
            KullaniciTablo= Yardimci.VtIslem.VeriGetir(sorgu);
            if(KullaniciTablo.Rows.Count <= 0 )
            {
                yokmu = true;
            }
            else
            {
                yokmu= false;
            }
        }
        #endregion

        #region Nesne Tanımlı Olaylar
        private void KullaniciGirisFormu_Load(object sender, EventArgs e)
        {
            KullaniciAdiTBox.Select();
            VeriDoldur();
            if (yokmu)
            {
                MessageBox.Show("Sistemde Oturum Açmak \n için Kullanıcı Tanımlamalısınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Kullanicilar = new YeniKullaniciForm();
                Kullanicilar.grsfrm = this;
                Kullanicilar.ShowDialog();
                VeriDoldur();
                if (yokmu)
                {
                    KullaniciGirisFormu_Load(sender, e);
                }
                else
                {
                    KullaniciAdiTBox.Select();
                }
            }
            else
            {
                KullaniciAdiTBox.Select();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string ad, sifre;
                for (int k = 0; k < KullaniciTablo.Rows.Count; k++)
                {
                    ad = KullaniciTablo.Rows[k].ItemArray[0].ToString();
                    sifre = KullaniciTablo.Rows[k].ItemArray[1].ToString();
                    if (ad == KullaniciAdiTBox.Text & sifre == SifreTBox.Text)
                    {
                        Yardimci.MusteriParametre.durum = true;
                        this.Close();
                        break;
                    }
                }
                if (!Yardimci.MusteriParametre.durum)
                {
                    MessageBox.Show("Girilen Verileri \nKontrol Ediniz", "Kontrol",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    KullaniciAdiTBox.Clear();
                    SifreTBox.Clear();
                    KullaniciAdiTBox.Select();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Bilgilerini \nKontrol Ediniz", "Kontrol",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (!Yardimci.MusteriParametre.durum)
                {
                    KullaniciAdiTBox.Clear();
                    SifreTBox.Clear();
                    KullaniciAdiTBox.Select();
                }
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulama \nSonlandırılsın mı?", "Çıkış Onayı",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Yardimci.MusteriParametre.durum = true;
                Yardimci.MusteriParametre.kapatma = true;
                Application.Exit();
            }
        }




        #endregion

        private void AcikGozPBox_Click(object sender, EventArgs e)
        {
            SifreTBox.PasswordChar = '\0'; 
            AcikGozPBox.Visible = false; 
            KapaliGozPBox.Visible = true;
        }

        private void KapaliGozPBox_Click(object sender, EventArgs e)
        {
            SifreTBox.PasswordChar = '*'; 
            KapaliGozPBox.Visible = false; 
            AcikGozPBox.Visible = true;
        }

        private void SidremiUnuttumLbl_Click(object sender, EventArgs e)
        {
            Sifrem = new SifremiUnuttum();
            Sifrem.giris = this;
            Sifrem.ShowDialog();
        }
    }
}
