
namespace Kafe_Otomasyonu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtbox_KullaniciSifre = new System.Windows.Forms.TextBox();
            this.txtbox_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_AltaAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_KullaniciSifre
            // 
            this.txtbox_KullaniciSifre.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_KullaniciSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_KullaniciSifre.Location = new System.Drawing.Point(799, 350);
            this.txtbox_KullaniciSifre.Name = "txtbox_KullaniciSifre";
            this.txtbox_KullaniciSifre.PasswordChar = '*';
            this.txtbox_KullaniciSifre.Size = new System.Drawing.Size(378, 44);
            this.txtbox_KullaniciSifre.TabIndex = 1;
            // 
            // txtbox_KullaniciAdi
            // 
            this.txtbox_KullaniciAdi.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_KullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtbox_KullaniciAdi.Location = new System.Drawing.Point(799, 259);
            this.txtbox_KullaniciAdi.Name = "txtbox_KullaniciAdi";
            this.txtbox_KullaniciAdi.Size = new System.Drawing.Size(378, 44);
            this.txtbox_KullaniciAdi.TabIndex = 0;
            // 
            // btn_Giris
            // 
            this.btn_Giris.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Giris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Giris.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Giris.Location = new System.Drawing.Point(799, 430);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(378, 101);
            this.btn_Giris.TabIndex = 12;
            this.btn_Giris.Text = "GİRİŞ YAP";
            this.btn_Giris.UseVisualStyleBackColor = false;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(793, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(793, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.btn_Cikis.FlatAppearance.BorderSize = 0;
            this.btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Cikis.Location = new System.Drawing.Point(1214, 0);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(75, 51);
            this.btn_Cikis.TabIndex = 13;
            this.btn_Cikis.Text = "X";
            this.btn_Cikis.UseVisualStyleBackColor = false;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_AltaAl
            // 
            this.btn_AltaAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(23)))), ((int)(((byte)(235)))));
            this.btn_AltaAl.FlatAppearance.BorderSize = 0;
            this.btn_AltaAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AltaAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_AltaAl.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AltaAl.Location = new System.Drawing.Point(1133, 0);
            this.btn_AltaAl.Name = "btn_AltaAl";
            this.btn_AltaAl.Size = new System.Drawing.Size(75, 51);
            this.btn_AltaAl.TabIndex = 14;
            this.btn_AltaAl.Text = "—";
            this.btn_AltaAl.UseVisualStyleBackColor = false;
            this.btn_AltaAl.Click += new System.EventHandler(this.btn_AltaAl_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Kafe_Otomasyonu.Properties.Resources.kafelogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 735);
            this.Controls.Add(this.btn_AltaAl);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.txtbox_KullaniciSifre);
            this.Controls.Add(this.txtbox_KullaniciAdi);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_KullaniciSifre;
        private System.Windows.Forms.TextBox txtbox_KullaniciAdi;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.Button btn_AltaAl;
    }
}

