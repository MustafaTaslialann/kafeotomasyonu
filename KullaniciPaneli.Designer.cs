
namespace Kafe_Otomasyonu
{
    partial class KullaniciPaneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciPaneli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AltaAl = new System.Windows.Forms.Button();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OturumuKapat = new System.Windows.Forms.Button();
            this.btn_AnaSayfa = new System.Windows.Forms.Button();
            this.btn_SiparisAl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.siparisAl1 = new Kafe_Otomasyonu.Kontroller.SiparisAl();
            this.anasayfa1 = new Kafe_Otomasyonu.Kontroller.Anasayfa();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.satislar1 = new Kafe_Otomasyonu.Kontroller.Satislar();
            this.btn_Satislar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_AltaAl);
            this.panel1.Controls.Add(this.btn_Cikis);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 79);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(87, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 44);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cafe Sorrento";
            // 
            // btn_AltaAl
            // 
            this.btn_AltaAl.BackColor = System.Drawing.Color.Transparent;
            this.btn_AltaAl.FlatAppearance.BorderSize = 0;
            this.btn_AltaAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AltaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AltaAl.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AltaAl.Location = new System.Drawing.Point(1394, 0);
            this.btn_AltaAl.Name = "btn_AltaAl";
            this.btn_AltaAl.Size = new System.Drawing.Size(75, 51);
            this.btn_AltaAl.TabIndex = 16;
            this.btn_AltaAl.Text = "—";
            this.btn_AltaAl.UseVisualStyleBackColor = false;
            this.btn_AltaAl.Click += new System.EventHandler(this.btn_AltaAl_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.Location = new System.Drawing.Point(1475, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(78, 51);
            this.btn_Cikis.TabIndex = 15;
            this.btn_Cikis.Text = "X";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.btn_Satislar);
            this.panel2.Controls.Add(this.btn_OturumuKapat);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Controls.Add(this.btn_AnaSayfa);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btn_SiparisAl);
            this.panel2.Controls.Add(this.pictureBox13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(428, 779);
            this.panel2.TabIndex = 2;
            // 
            // btn_OturumuKapat
            // 
            this.btn_OturumuKapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_OturumuKapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_OturumuKapat.FlatAppearance.BorderSize = 0;
            this.btn_OturumuKapat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_OturumuKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_OturumuKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OturumuKapat.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_OturumuKapat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OturumuKapat.Location = new System.Drawing.Point(3, 700);
            this.btn_OturumuKapat.Name = "btn_OturumuKapat";
            this.btn_OturumuKapat.Size = new System.Drawing.Size(343, 67);
            this.btn_OturumuKapat.TabIndex = 9;
            this.btn_OturumuKapat.Text = "Oturumu Kapat";
            this.btn_OturumuKapat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OturumuKapat.UseVisualStyleBackColor = false;
            this.btn_OturumuKapat.Click += new System.EventHandler(this.btn_OturumuKapat_Click);
            // 
            // btn_AnaSayfa
            // 
            this.btn_AnaSayfa.BackColor = System.Drawing.Color.Transparent;
            this.btn_AnaSayfa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_AnaSayfa.FlatAppearance.BorderSize = 0;
            this.btn_AnaSayfa.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_AnaSayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_AnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnaSayfa.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AnaSayfa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AnaSayfa.Location = new System.Drawing.Point(78, 3);
            this.btn_AnaSayfa.Name = "btn_AnaSayfa";
            this.btn_AnaSayfa.Size = new System.Drawing.Size(346, 67);
            this.btn_AnaSayfa.TabIndex = 7;
            this.btn_AnaSayfa.Text = "Anasayfa";
            this.btn_AnaSayfa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AnaSayfa.UseVisualStyleBackColor = false;
            this.btn_AnaSayfa.Click += new System.EventHandler(this.btn_AnaSayfa_Click);
            // 
            // btn_SiparisAl
            // 
            this.btn_SiparisAl.BackColor = System.Drawing.Color.Transparent;
            this.btn_SiparisAl.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_SiparisAl.FlatAppearance.BorderSize = 0;
            this.btn_SiparisAl.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_SiparisAl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_SiparisAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SiparisAl.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SiparisAl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SiparisAl.Location = new System.Drawing.Point(78, 92);
            this.btn_SiparisAl.Name = "btn_SiparisAl";
            this.btn_SiparisAl.Size = new System.Drawing.Size(346, 67);
            this.btn_SiparisAl.TabIndex = 7;
            this.btn_SiparisAl.Text = "Sipariş Al";
            this.btn_SiparisAl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SiparisAl.UseVisualStyleBackColor = false;
            this.btn_SiparisAl.Click += new System.EventHandler(this.btn_SiparisAl_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lbl_Tarih);
            this.panel3.Location = new System.Drawing.Point(426, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1127, 68);
            this.panel3.TabIndex = 3;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.AutoSize = true;
            this.lbl_Tarih.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tarih.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Tarih.Location = new System.Drawing.Point(879, 15);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(64, 28);
            this.lbl_Tarih.TabIndex = 1;
            this.lbl_Tarih.Text = "Tarih";
            // 
            // siparisAl1
            // 
            this.siparisAl1.BackColor = System.Drawing.Color.White;
            this.siparisAl1.Location = new System.Drawing.Point(426, 145);
            this.siparisAl1.Name = "siparisAl1";
            this.siparisAl1.Size = new System.Drawing.Size(1127, 713);
            this.siparisAl1.TabIndex = 5;
            // 
            // anasayfa1
            // 
            this.anasayfa1.BackColor = System.Drawing.Color.White;
            this.anasayfa1.Location = new System.Drawing.Point(426, 145);
            this.anasayfa1.Name = "anasayfa1";
            this.anasayfa1.Size = new System.Drawing.Size(1127, 713);
            this.anasayfa1.TabIndex = 4;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::Kafe_Otomasyonu.Properties.Resources.logout_rounded_up_96px;
            this.pictureBox10.Location = new System.Drawing.Point(352, 700);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(72, 67);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 8;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kafe_Otomasyonu.Properties.Resources.home_page_50px;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Kafe_Otomasyonu.Properties.Resources.total_sales_240px;
            this.pictureBox2.Location = new System.Drawing.Point(3, 186);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Kafe_Otomasyonu.Properties.Resources.money_100px;
            this.pictureBox13.Location = new System.Drawing.Point(3, 92);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(69, 67);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 6;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::Kafe_Otomasyonu.Properties.Resources.icons8_cornucopia_64;
            this.pictureBox11.Location = new System.Drawing.Point(12, 7);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(69, 66);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // satislar1
            // 
            this.satislar1.BackColor = System.Drawing.Color.White;
            this.satislar1.Location = new System.Drawing.Point(426, 145);
            this.satislar1.Name = "satislar1";
            this.satislar1.Size = new System.Drawing.Size(1127, 713);
            this.satislar1.TabIndex = 6;
            // 
            // btn_Satislar
            // 
            this.btn_Satislar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Satislar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Satislar.FlatAppearance.BorderSize = 0;
            this.btn_Satislar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Satislar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Satislar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Satislar.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Satislar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Satislar.Location = new System.Drawing.Point(78, 186);
            this.btn_Satislar.Name = "btn_Satislar";
            this.btn_Satislar.Size = new System.Drawing.Size(350, 67);
            this.btn_Satislar.TabIndex = 10;
            this.btn_Satislar.Text = "Satışlar";
            this.btn_Satislar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Satislar.UseVisualStyleBackColor = false;
            this.btn_Satislar.Click += new System.EventHandler(this.btn_Satislar_Click);
            // 
            // KullaniciPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1553, 858);
            this.Controls.Add(this.satislar1);
            this.Controls.Add(this.siparisAl1);
            this.Controls.Add(this.anasayfa1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciPaneli";
            this.Load += new System.EventHandler(this.KullaniciPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AltaAl;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_SiparisAl;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button btn_OturumuKapat;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Button btn_AnaSayfa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Kontroller.Anasayfa anasayfa1;
        private Kontroller.SiparisAl siparisAl1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Kontroller.Satislar satislar1;
        private System.Windows.Forms.Button btn_Satislar;
    }
}