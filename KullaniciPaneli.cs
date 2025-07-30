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
    public partial class KullaniciPaneli : Form
    {
        public KullaniciPaneli()
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

        private void KullaniciPaneli_Load(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToString();
            anasayfa1.Visible = true;
            siparisAl1.Visible = false;
            satislar1.Visible = false;
        }

        private void btn_OturumuKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            anasayfa1.Visible = true;
            anasayfa1.BringToFront();
        }

        private void btn_SiparisAl_Click(object sender, EventArgs e)
        {
            siparisAl1.Visible = true;
            siparisAl1.BringToFront();
        }

        private void btn_Satislar_Click(object sender, EventArgs e)
        {
            satislar1.Visible = true;
            satislar1.BringToFront();
            satislar1.SatislariGetir();
        }
    }
}
