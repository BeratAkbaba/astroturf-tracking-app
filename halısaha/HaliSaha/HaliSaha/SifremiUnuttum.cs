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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        public KullaniciGirisFormu giris;
        #region Değişkenler ve Tanımlamalar        

        static string VtAdres = "Data Source=localhost;Initial Catalog=HalisahaVT; User Id=sa;Password=mmyo;";
        SqlConnection MusConn = new SqlConnection(VtAdres);
        SqlDataAdapter MusAdp;
        SqlCommand MusCmd = new SqlCommand();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        #endregion

        #region Nesne Tanımlı Olaylar


        #endregion
    }
}
