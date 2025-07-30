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
    class Adminİslemleri
    {
        public DataSet getData(string sorgu)
        {
            SqlConnection con = new SqlConnection(Veritabani.SqlCon);
            SqlCommand cmd = new SqlCommand(sorgu,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void setData(string sorgu)
        {
            SqlConnection con = new SqlConnection(Veritabani.SqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("İşlem Başarılı!");
        }
    }
}
