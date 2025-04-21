namespace HaliSaha
{
    partial class RezervasyonDuzenlemeFormu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonDuzenlemeFormu));
            this.label9 = new System.Windows.Forms.Label();
            this.tarihdtp = new System.Windows.Forms.DateTimePicker();
            this.cb_saat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_rezdurumu = new System.Windows.Forms.ComboBox();
            this.chb_depozito = new System.Windows.Forms.CheckBox();
            this.depozitotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IptalEt = new System.Windows.Forms.Button();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.cb_odeme = new System.Windows.Forms.ComboBox();
            this.toplamtutartxt = new System.Windows.Forms.TextBox();
            this.kalecitxt = new System.Windows.Forms.TextBox();
            this.ListViewContextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SilTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.adisoyaditxt = new System.Windows.Forms.TextBox();
            this.cb_saha = new System.Windows.Forms.ComboBox();
            this.EkipmanPanel = new System.Windows.Forms.Panel();
            this.EldivenBtn = new System.Windows.Forms.Button();
            this.KramponBtn = new System.Windows.Forms.Button();
            this.EkipmanlarLV = new System.Windows.Forms.ListView();
            this.EkleLbl = new System.Windows.Forms.Label();
            this.GuncelleLbl = new System.Windows.Forms.Label();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EkipmanKapatPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EkipmanAcPBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListViewContextBox.SuspendLayout();
            this.EkipmanPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkipmanKapatPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkipmanAcPBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(295, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Saha :";
            // 
            // tarihdtp
            // 
            this.tarihdtp.Location = new System.Drawing.Point(382, 30);
            this.tarihdtp.Name = "tarihdtp";
            this.tarihdtp.Size = new System.Drawing.Size(199, 22);
            this.tarihdtp.TabIndex = 1;
            // 
            // cb_saat
            // 
            this.cb_saat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_saat.FormattingEnabled = true;
            this.cb_saat.Location = new System.Drawing.Point(96, 89);
            this.cb_saat.Name = "cb_saat";
            this.cb_saat.Size = new System.Drawing.Size(129, 24);
            this.cb_saat.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Rezervasyon Durumu:";
            // 
            // cb_rezdurumu
            // 
            this.cb_rezdurumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_rezdurumu.FormattingEnabled = true;
            this.cb_rezdurumu.Location = new System.Drawing.Point(203, 521);
            this.cb_rezdurumu.Name = "cb_rezdurumu";
            this.cb_rezdurumu.Size = new System.Drawing.Size(129, 24);
            this.cb_rezdurumu.TabIndex = 69;
            // 
            // chb_depozito
            // 
            this.chb_depozito.AutoSize = true;
            this.chb_depozito.Location = new System.Drawing.Point(259, 476);
            this.chb_depozito.Name = "chb_depozito";
            this.chb_depozito.Size = new System.Drawing.Size(62, 20);
            this.chb_depozito.TabIndex = 7;
            this.chb_depozito.Text = "Alındı";
            this.chb_depozito.UseVisualStyleBackColor = true;
            // 
            // depozitotxt
            // 
            this.depozitotxt.Location = new System.Drawing.Point(140, 472);
            this.depozitotxt.Name = "depozitotxt";
            this.depozitotxt.ReadOnly = true;
            this.depozitotxt.Size = new System.Drawing.Size(100, 22);
            this.depozitotxt.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Depozito:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Toplam Tutar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "Kaleci:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ekipman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Saat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Adı Soyadı:";
            // 
            // btn_IptalEt
            // 
            this.btn_IptalEt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_IptalEt.Location = new System.Drawing.Point(418, 515);
            this.btn_IptalEt.Name = "btn_IptalEt";
            this.btn_IptalEt.Size = new System.Drawing.Size(81, 35);
            this.btn_IptalEt.TabIndex = 9;
            this.btn_IptalEt.Text = "İptal Et";
            this.btn_IptalEt.UseVisualStyleBackColor = false;
            this.btn_IptalEt.Click += new System.EventHandler(this.btn_IptalEt_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Kaydet.Location = new System.Drawing.Point(515, 515);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(81, 35);
            this.btn_Kaydet.TabIndex = 8;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = false;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // cb_odeme
            // 
            this.cb_odeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_odeme.FormattingEnabled = true;
            this.cb_odeme.Location = new System.Drawing.Point(259, 415);
            this.cb_odeme.Name = "cb_odeme";
            this.cb_odeme.Size = new System.Drawing.Size(96, 24);
            this.cb_odeme.TabIndex = 6;
            // 
            // toplamtutartxt
            // 
            this.toplamtutartxt.Location = new System.Drawing.Point(140, 415);
            this.toplamtutartxt.Name = "toplamtutartxt";
            this.toplamtutartxt.ReadOnly = true;
            this.toplamtutartxt.Size = new System.Drawing.Size(100, 22);
            this.toplamtutartxt.TabIndex = 56;
            // 
            // kalecitxt
            // 
            this.kalecitxt.Location = new System.Drawing.Point(111, 231);
            this.kalecitxt.Name = "kalecitxt";
            this.kalecitxt.Size = new System.Drawing.Size(129, 22);
            this.kalecitxt.TabIndex = 4;
            // 
            // ListViewContextBox
            // 
            this.ListViewContextBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListViewContextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SilTSMI});
            this.ListViewContextBox.Name = "contextMenuStrip2";
            this.ListViewContextBox.Size = new System.Drawing.Size(95, 28);
            // 
            // SilTSMI
            // 
            this.SilTSMI.Name = "SilTSMI";
            this.SilTSMI.Size = new System.Drawing.Size(94, 24);
            this.SilTSMI.Text = "Sil";
            this.SilTSMI.Click += new System.EventHandler(this.SilTSMI_Click);
            // 
            // adisoyaditxt
            // 
            this.adisoyaditxt.Location = new System.Drawing.Point(96, 30);
            this.adisoyaditxt.Name = "adisoyaditxt";
            this.adisoyaditxt.Size = new System.Drawing.Size(150, 22);
            this.adisoyaditxt.TabIndex = 0;
            // 
            // cb_saha
            // 
            this.cb_saha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_saha.FormattingEnabled = true;
            this.cb_saha.Items.AddRange(new object[] {
            "<-Seçiniz->",
            "Saha1",
            "Saha2",
            "Saha3",
            "Saha4"});
            this.cb_saha.Location = new System.Drawing.Point(382, 89);
            this.cb_saha.Name = "cb_saha";
            this.cb_saha.Size = new System.Drawing.Size(99, 24);
            this.cb_saha.TabIndex = 3;
            this.cb_saha.DropDownClosed += new System.EventHandler(this.cb_saha_DropDownClosed);
            // 
            // EkipmanPanel
            // 
            this.EkipmanPanel.Controls.Add(this.EldivenBtn);
            this.EkipmanPanel.Controls.Add(this.KramponBtn);
            this.EkipmanPanel.Location = new System.Drawing.Point(417, 295);
            this.EkipmanPanel.Name = "EkipmanPanel";
            this.EkipmanPanel.Size = new System.Drawing.Size(81, 57);
            this.EkipmanPanel.TabIndex = 80;
            // 
            // EldivenBtn
            // 
            this.EldivenBtn.Location = new System.Drawing.Point(1, 30);
            this.EldivenBtn.Name = "EldivenBtn";
            this.EldivenBtn.Size = new System.Drawing.Size(77, 26);
            this.EldivenBtn.TabIndex = 82;
            this.EldivenBtn.Text = "Eldiven";
            this.EldivenBtn.UseVisualStyleBackColor = true;
            this.EldivenBtn.Click += new System.EventHandler(this.EldivenBtn_Click);
            // 
            // KramponBtn
            // 
            this.KramponBtn.Location = new System.Drawing.Point(1, 0);
            this.KramponBtn.Name = "KramponBtn";
            this.KramponBtn.Size = new System.Drawing.Size(77, 26);
            this.KramponBtn.TabIndex = 81;
            this.KramponBtn.Text = "Krampon";
            this.KramponBtn.UseVisualStyleBackColor = true;
            this.KramponBtn.Click += new System.EventHandler(this.KramponBtn_Click);
            // 
            // EkipmanlarLV
            // 
            this.EkipmanlarLV.ContextMenuStrip = this.ListViewContextBox;
            this.EkipmanlarLV.HideSelection = false;
            this.EkipmanlarLV.Location = new System.Drawing.Point(111, 296);
            this.EkipmanlarLV.Name = "EkipmanlarLV";
            this.EkipmanlarLV.Size = new System.Drawing.Size(261, 97);
            this.EkipmanlarLV.TabIndex = 5;
            this.EkipmanlarLV.UseCompatibleStateImageBehavior = false;
            // 
            // EkleLbl
            // 
            this.EkleLbl.AutoSize = true;
            this.EkleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EkleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleLbl.Location = new System.Drawing.Point(22, 46);
            this.EkleLbl.Name = "EkleLbl";
            this.EkleLbl.Size = new System.Drawing.Size(291, 29);
            this.EkleLbl.TabIndex = 86;
            this.EkleLbl.Text = "Rezervasyon Ekleme Formu";
            // 
            // GuncelleLbl
            // 
            this.GuncelleLbl.AutoSize = true;
            this.GuncelleLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GuncelleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GuncelleLbl.Location = new System.Drawing.Point(18, 46);
            this.GuncelleLbl.Name = "GuncelleLbl";
            this.GuncelleLbl.Size = new System.Drawing.Size(337, 29);
            this.GuncelleLbl.TabIndex = 87;
            this.GuncelleLbl.Text = "Rezervasyon Güncelleme Formu";
            this.GuncelleLbl.Visible = false;
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GuncelleBtn.Location = new System.Drawing.Point(515, 515);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(81, 35);
            this.GuncelleBtn.TabIndex = 88;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Visible = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::HaliSaha.Properties.Resources.exit_full_screen1;
            this.pictureBox3.Location = new System.Drawing.Point(584, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 85;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // EkipmanKapatPBox
            // 
            this.EkipmanKapatPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EkipmanKapatPBox.Image = global::HaliSaha.Properties.Resources._3994413_above_arrow_navigation_top_up_icon;
            this.EkipmanKapatPBox.Location = new System.Drawing.Point(382, 295);
            this.EkipmanKapatPBox.Name = "EkipmanKapatPBox";
            this.EkipmanKapatPBox.Size = new System.Drawing.Size(27, 25);
            this.EkipmanKapatPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EkipmanKapatPBox.TabIndex = 83;
            this.EkipmanKapatPBox.TabStop = false;
            this.EkipmanKapatPBox.Click += new System.EventHandler(this.EkipmanKapatPBox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::HaliSaha.Properties.Resources._3994355_arrow_bottom_down_downward_navigation_icon;
            this.pictureBox2.Location = new System.Drawing.Point(246, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // EkipmanAcPBox
            // 
            this.EkipmanAcPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EkipmanAcPBox.Image = global::HaliSaha.Properties.Resources._3994355_arrow_bottom_down_downward_navigation_icon;
            this.EkipmanAcPBox.Location = new System.Drawing.Point(382, 295);
            this.EkipmanAcPBox.Name = "EkipmanAcPBox";
            this.EkipmanAcPBox.Size = new System.Drawing.Size(27, 25);
            this.EkipmanAcPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EkipmanAcPBox.TabIndex = 81;
            this.EkipmanAcPBox.TabStop = false;
            this.EkipmanAcPBox.Click += new System.EventHandler(this.EkipmanAcPBox_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adisoyaditxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_saat);
            this.panel1.Controls.Add(this.tarihdtp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cb_saha);
            this.panel1.Location = new System.Drawing.Point(12, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 121);
            this.panel1.TabIndex = 89;
            // 
            // RezervasyonDuzenlemeFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(641, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GuncelleBtn);
            this.Controls.Add(this.GuncelleLbl);
            this.Controls.Add(this.EkleLbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EkipmanlarLV);
            this.Controls.Add(this.EkipmanKapatPBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.EkipmanAcPBox);
            this.Controls.Add(this.EkipmanPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_rezdurumu);
            this.Controls.Add(this.chb_depozito);
            this.Controls.Add(this.depozitotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_IptalEt);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.cb_odeme);
            this.Controls.Add(this.toplamtutartxt);
            this.Controls.Add(this.kalecitxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RezervasyonDuzenlemeFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Düzenleme Formu";
            this.Load += new System.EventHandler(this.RezervasyonDuzenlemeFormu_Load);
            this.ListViewContextBox.ResumeLayout(false);
            this.EkipmanPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkipmanKapatPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EkipmanAcPBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_IptalEt;
        private System.Windows.Forms.ContextMenuStrip ListViewContextBox;
        private System.Windows.Forms.ToolStripMenuItem SilTSMI;
        private System.Windows.Forms.Panel EkipmanPanel;
        private System.Windows.Forms.Button EldivenBtn;
        private System.Windows.Forms.Button KramponBtn;
        private System.Windows.Forms.PictureBox EkipmanAcPBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox EkipmanKapatPBox;
        public System.Windows.Forms.ListView EkipmanlarLV;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.DateTimePicker tarihdtp;
        public System.Windows.Forms.ComboBox cb_saat;
        public System.Windows.Forms.ComboBox cb_rezdurumu;
        public System.Windows.Forms.CheckBox chb_depozito;
        public System.Windows.Forms.TextBox depozitotxt;
        public System.Windows.Forms.ComboBox cb_odeme;
        public System.Windows.Forms.TextBox toplamtutartxt;
        public System.Windows.Forms.TextBox kalecitxt;
        public System.Windows.Forms.TextBox adisoyaditxt;
        public System.Windows.Forms.ComboBox cb_saha;
        public System.Windows.Forms.Button GuncelleBtn;
        public System.Windows.Forms.Button btn_Kaydet;
        public System.Windows.Forms.Label EkleLbl;
        public System.Windows.Forms.Label GuncelleLbl;
        private System.Windows.Forms.Panel panel1;
    }
}