using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe_Otomasyonu
{
    class Veritabani
    {
        SqlConnection con;
        public static string SqlCon =
            "Data Source=DESKTOP-7O1I8L9\\SQLEXPRESS;Initial Catalog=Kafe Otomasyonu;Integrated Security=true";


        public  bool BaglantiDurum()
        {
            using (con = new SqlConnection(SqlCon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }

        }

        public static bool LoginControl(string kullaniciAdi, string sifre)
        {
            bool durum = false;

            string sorgu = "Select * from tbl_Kullanicilar where kullaniciAdi=@user and kullaniciSifre=@pass";
            SqlConnection con = new SqlConnection(Veritabani.SqlCon);
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@pass", MD5Sifrele.Sifrele(sifre));
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                durum = Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }



            return durum;
        }

    }
}
