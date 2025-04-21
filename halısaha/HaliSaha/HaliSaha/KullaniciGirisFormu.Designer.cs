namespace HaliSaha
{
    partial class KullaniciGirisFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisFormu));
            this.KullaniciAdiLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdiTBox = new System.Windows.Forms.TextBox();
            this.SifreTBox = new System.Windows.Forms.TextBox();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.SidremiUnuttumLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AcikGozPBox = new System.Windows.Forms.PictureBox();
            this.KapaliGozPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcikGozPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapaliGozPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // KullaniciAdiLBL
            // 
            this.KullaniciAdiLBL.AutoSize = true;
            this.KullaniciAdiLBL.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdiLBL.Location = new System.Drawing.Point(32, 58);
            this.KullaniciAdiLBL.Name = "KullaniciAdiLBL";
            this.KullaniciAdiLBL.Size = new System.Drawing.Size(116, 22);
            this.KullaniciAdiLBL.TabIndex = 0;
            this.KullaniciAdiLBL.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // KullaniciAdiTBox
            // 
            this.KullaniciAdiTBox.Location = new System.Drawing.Point(181, 58);
            this.KullaniciAdiTBox.Name = "KullaniciAdiTBox";
            this.KullaniciAdiTBox.Size = new System.Drawing.Size(174, 22);
            this.KullaniciAdiTBox.TabIndex = 0;
            // 
            // SifreTBox
            // 
            this.SifreTBox.Location = new System.Drawing.Point(181, 106);
            this.SifreTBox.Name = "SifreTBox";
            this.SifreTBox.PasswordChar = '*';
            this.SifreTBox.Size = new System.Drawing.Size(174, 22);
            this.SifreTBox.TabIndex = 1;
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.Blue;
            this.GirisBtn.FlatAppearance.BorderSize = 0;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisBtn.ForeColor = System.Drawing.Color.White;
            this.GirisBtn.Location = new System.Drawing.Point(36, 172);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(319, 31);
            this.GirisBtn.TabIndex = 2;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SidremiUnuttumLbl
            // 
            this.SidremiUnuttumLbl.AutoSize = true;
            this.SidremiUnuttumLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SidremiUnuttumLbl.Location = new System.Drawing.Point(259, 219);
            this.SidremiUnuttumLbl.Name = "SidremiUnuttumLbl";
            this.SidremiUnuttumLbl.Size = new System.Drawing.Size(96, 16);
            this.SidremiUnuttumLbl.TabIndex = 3;
            this.SidremiUnuttumLbl.Text = "Şifremi unuttum";
            this.SidremiUnuttumLbl.Click += new System.EventHandler(this.SidremiUnuttumLbl_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AcikGozPBox);
            this.groupBox1.Controls.Add(this.KullaniciAdiLBL);
            this.groupBox1.Controls.Add(this.SidremiUnuttumLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GirisBtn);
            this.groupBox1.Controls.Add(this.KullaniciAdiTBox);
            this.groupBox1.Controls.Add(this.SifreTBox);
            this.groupBox1.Controls.Add(this.KapaliGozPBox);
            this.groupBox1.Location = new System.Drawing.Point(526, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 267);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // AcikGozPBox
            // 
            this.AcikGozPBox.Image = global::HaliSaha.Properties.Resources.eye;
            this.AcikGozPBox.Location = new System.Drawing.Point(361, 108);
            this.AcikGozPBox.Name = "AcikGozPBox";
            this.AcikGozPBox.Size = new System.Drawing.Size(30, 20);
            this.AcikGozPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AcikGozPBox.TabIndex = 6;
            this.AcikGozPBox.TabStop = false;
            this.AcikGozPBox.Click += new System.EventHandler(this.AcikGozPBox_Click);
            // 
            // KapaliGozPBox
            // 
            this.KapaliGozPBox.Image = global::HaliSaha.Properties.Resources.hidden;
            this.KapaliGozPBox.Location = new System.Drawing.Point(361, 108);
            this.KapaliGozPBox.Name = "KapaliGozPBox";
            this.KapaliGozPBox.Size = new System.Drawing.Size(30, 20);
            this.KapaliGozPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KapaliGozPBox.TabIndex = 7;
            this.KapaliGozPBox.TabStop = false;
            this.KapaliGozPBox.Click += new System.EventHandler(this.KapaliGozPBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HaliSaha.Properties.Resources.football_player;
            this.pictureBox4.Location = new System.Drawing.Point(73, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(298, 267);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HaliSaha.Properties.Resources.exit_full_screen1;
            this.pictureBox3.Location = new System.Drawing.Point(954, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // KullaniciGirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HaliSaha.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(1017, 528);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciGirisFormu";
            this.Load += new System.EventHandler(this.KullaniciGirisFormu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcikGozPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KapaliGozPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label KullaniciAdiLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdiTBox;
        private System.Windows.Forms.TextBox SifreTBox;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Label SidremiUnuttumLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox AcikGozPBox;
        private System.Windows.Forms.PictureBox KapaliGozPBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}