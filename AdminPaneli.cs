using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kafe_Otomasyonu.Kontroller;

namespace Kafe_Otomasyonu
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AltaAl_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_OturumuKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void AdminPaneli_Load(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToString();
            kullaniciHareketleri3.Visible = false;
            urunEkle1.Visible = false;
            anasayfa1.Visible = true;
            urunGuncelle1.Visible = false;
            urunSil1.Visible = false;
            kullaniciEkle1.Visible = false;
            kullaniciSil1.Visible = false;
            sifreOlusturucu1.Visible = false;
            sifreDegistir1.Visible =false;
            satislar1.Visible = false;
        }


        private void btn_Anasayfa_Click(object sender, EventArgs e)
        {
            anasayfa1.Visible = true;
            anasayfa1.BringToFront();
        }

        private void btn_KullaniciHareketleri_Click(object sender, EventArgs e)
        {
            kullaniciHareketleri3.Visible = true;
            kullaniciHareketleri3.BringToFront();
            kullaniciHareketleri3.KullaniciHareketleriniGetir();
            
        }

        private void btn_UrunEkle_Click(object sender, EventArgs e)
        {
            urunEkle1.Visible = true;
            urunEkle1.BringToFront();
        }

        private void btn_UrunGuncelle_Click_1(object sender, EventArgs e)
        {
            urunGuncelle1.Visible = true;
            urunGuncelle1.BringToFront();
            urunGuncelle1.UrunleriGetir();
        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            urunSil1.Visible = true;
            urunSil1.BringToFront();
            urunSil1.UrunleriGetir();
        }

        private void btn_KullaniciEkle_Click(object sender, EventArgs e)
        {
            kullaniciEkle1.Visible = true;
            kullaniciEkle1.BringToFront();
            kullaniciEkle1.KullanicilariGetir();
        }

        private void btn_KullaniciSil_Click(object sender, EventArgs e)
        {
            kullaniciSil1.Visible = true;
            kullaniciSil1.BringToFront();
            kullaniciSil1.KullanicilariGetir();
        }

        private void btn_SifreOlustur_Click(object sender, EventArgs e)
        {
            sifreOlusturucu1.Visible = true;
            sifreOlusturucu1.BringToFront();
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            sifreDegistir1.Visible = true;
            sifreDegistir1.BringToFront();
        }

        private void btn_Satislar_Click(object sender, EventArgs e)
        {
            satislar1.Visible = true;
            satislar1.BringToFront();
            satislar1.SatislariGetir();
        }
    }
}
