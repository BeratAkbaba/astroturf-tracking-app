using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSaha
{
    static class Yardimci
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm());
        }
        public class VtBaglanti
        {
            public static string VtAdres =
                "Server=.;Database=HalisahaVT;User Id=sa;Password=mmyo;";
        }
        public class MusteriParametre
        {
            public static int IslemDurumu;
            public static bool durum = false;
            public static bool kapatma = false;
            public static string yetkili;
        }
        public class VtIslem
        {
            #region Değişkenler ve Tanımlamalar
            static SqlConnection MusConn = new SqlConnection(VtBaglanti.VtAdres);
            static SqlDataAdapter MusAdp;
            public static SqlCommand MusCmd = new SqlCommand();
            #endregion
            #region Kullanıcı Tanımlı Olaylar
            public static DataTable VeriGetir(string Sorgu)
            {
                DataTable MusTablo = new DataTable();
                MusTablo.Clear();
                MusAdp = new SqlDataAdapter(Sorgu, MusConn);
                MusAdp.Fill(MusTablo);
                return MusTablo;
            }

            public static void KomutCalistir(string Komut)
            {
                try
                {
                    if (MusConn.State == ConnectionState.Closed)
                        MusConn.Open();
                    MusCmd.CommandText = Komut;
                    MusCmd.Connection = MusConn;
                    MusteriParametre.IslemDurumu = MusCmd.ExecuteNonQuery();
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (MusConn.State == ConnectionState.Open)
                        MusConn.Close();
                }
            }
            #endregion
        }
    }

}
