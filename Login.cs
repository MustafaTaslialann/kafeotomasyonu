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

namespace Kafe_Otomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private Veritabani vt = new Veritabani();
        public static string kullaniciSession="";
        private void Login_Load(object sender, EventArgs e)
        {
            vt.BaglantiDurum();
        }

        public static int _kullaniciId;
        public void Giris()
        {

            string sorgu = "Select * from tbl_Kullanicilar where kullaniciAdi=@user and kullaniciSifre=@pass";
            SqlConnection con = new SqlConnection(Veritabani.SqlCon);
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", txtbox_KullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@pass", MD5Sifrele.Sifrele(txtbox_KullaniciSifre.Text));
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (txtbox_KullaniciAdi.Text == "" && txtbox_KullaniciSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş geçilemez!");
            }
            else if (dr.Read() == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                txtbox_KullaniciAdi.Clear();
                txtbox_KullaniciSifre.Clear();
                txtbox_KullaniciAdi.Focus();
            }
            if (Veritabani.LoginControl(txtbox_KullaniciAdi.Text, txtbox_KullaniciSifre.Text) && dr["yetki"].ToString() == "Admin")
            {
                this.Hide();
                AdminPaneli ap = new AdminPaneli();
                ap.Show();
                _kullaniciId = Convert.ToInt32(dr["kullaniciId"]);
                kullaniciSession = txtbox_KullaniciAdi.Text;
                KullaniciSession();

            }
            if (Veritabani.LoginControl(txtbox_KullaniciAdi.Text, txtbox_KullaniciSifre.Text) && dr["yetki"].ToString() == "Personel")
            {
                this.Hide();
                KullaniciPaneli kp = new KullaniciPaneli();
                kp.Show();
                _kullaniciId = Convert.ToInt32(dr["kullaniciId"]);
                kullaniciSession = txtbox_KullaniciAdi.Text;
                KullaniciSession();
            }
            con.Close();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            Giris();
        }
        public void KullaniciSession()
        {
            KullaniciHareketleri kh = new KullaniciHareketleri();
            kh.KullaniciId = _kullaniciId;
            kh.Islem = "Oturum açıldı";
            kh.IslemTarihi = DateTime.Now;
            kh.Durum = true;
            kh.KullaniciEylemleri(kh);
        }

        private void btn_AltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
