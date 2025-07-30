using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kafe_Otomasyonu.Kontroller;

namespace Kafe_Otomasyonu
{
    class KullaniciHareketleri
    {
        private int _id;
        private int _kullaniciId;
        private string _islem;
        private DateTime _islemTarihi;
        private bool _durum;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int KullaniciId
        {
            get { return _kullaniciId; }
            set { _kullaniciId = value; }
        }

        public string Islem
        {
            get { return _islem; }
            set { _islem = value; }
        }

        public DateTime IslemTarihi
        {
            get { return _islemTarihi; }
            set { _islemTarihi = value; }
        }

        public bool Durum
        {
            get { return _durum; }
            set { _durum = value; }
        }




        public bool KullaniciEylemleri(KullaniciHareketleri kh)
        {
            Veritabani vt = new Veritabani();
            bool durum = false;
            string sorgu =
                "Insert into tbl_kullaniciHareketleri(kullaniciId,islemAciklama,islemTarihi,durum) values(@k_Id,@k_Islem,@k_IslemTarihi,@k_Durum)";
            SqlConnection con = new SqlConnection(Veritabani.SqlCon);
            SqlCommand cmd = new SqlCommand(sorgu, con);
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                cmd.Parameters.AddWithValue("@k_Id", kh._kullaniciId);
                cmd.Parameters.AddWithValue("@k_Islem", kh._islem);
                cmd.Parameters.AddWithValue("@k_IslemTarihi", kh._islemTarihi);
                cmd.Parameters.AddWithValue("@k_Durum", kh._durum);
                durum = Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SqlException ex)
            {
                string hata = ex.Message;
            }
            return durum;
        }

    }
}
