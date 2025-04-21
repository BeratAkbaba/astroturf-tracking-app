namespace HaliSaha
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rezervasyonEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonDuzenleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.sahaDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sahaDurumuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ekipmanBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜrünGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaleciDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KalecilerTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kapatTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DurumDgv = new System.Windows.Forms.DataGridView();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurumDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonEkleToolStripMenuItem,
            this.sahaDurumuToolStripMenuItem,
            this.ekipmanBilgisiToolStripMenuItem,
            this.kaleciDurumuToolStripMenuItem,
            this.yeniToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervasyonEkleToolStripMenuItem
            // 
            this.rezervasyonEkleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonDuzenleTSMI});
            this.rezervasyonEkleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rezervasyonEkleToolStripMenuItem.Name = "rezervasyonEkleToolStripMenuItem";
            this.rezervasyonEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.rezervasyonEkleToolStripMenuItem.Size = new System.Drawing.Size(134, 32);
            this.rezervasyonEkleToolStripMenuItem.Text = "Rezervasyon";
            // 
            // rezervasyonDuzenleTSMI
            // 
            this.rezervasyonDuzenleTSMI.Name = "rezervasyonDuzenleTSMI";
            this.rezervasyonDuzenleTSMI.Size = new System.Drawing.Size(281, 32);
            this.rezervasyonDuzenleTSMI.Text = "&Rezervasyon Düzenle";
            this.rezervasyonDuzenleTSMI.Click += new System.EventHandler(this.rezervasyonDuzenleTSMI_Click);
            // 
            // sahaDurumuToolStripMenuItem
            // 
            this.sahaDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sahaDurumuTSMI});
            this.sahaDurumuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sahaDurumuToolStripMenuItem.Name = "sahaDurumuToolStripMenuItem";
            this.sahaDurumuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.sahaDurumuToolStripMenuItem.Size = new System.Drawing.Size(68, 32);
            this.sahaDurumuToolStripMenuItem.Text = "Saha";
            // 
            // sahaDurumuTSMI
            // 
            this.sahaDurumuTSMI.Name = "sahaDurumuTSMI";
            this.sahaDurumuTSMI.Size = new System.Drawing.Size(216, 32);
            this.sahaDurumuTSMI.Text = "&Saha Durumu";
            this.sahaDurumuTSMI.Click += new System.EventHandler(this.sahaDurumuTSMI_Click);
            // 
            // ekipmanBilgisiToolStripMenuItem
            // 
            this.ekipmanBilgisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜrünGirişiToolStripMenuItem});
            this.ekipmanBilgisiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekipmanBilgisiToolStripMenuItem.Name = "ekipmanBilgisiToolStripMenuItem";
            this.ekipmanBilgisiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.ekipmanBilgisiToolStripMenuItem.Size = new System.Drawing.Size(106, 32);
            this.ekipmanBilgisiToolStripMenuItem.Text = "Ekipman ";
            this.ekipmanBilgisiToolStripMenuItem.Click += new System.EventHandler(this.ekipmanBilgisiToolStripMenuItem_Click);
            // 
            // yeniÜrünGirişiToolStripMenuItem
            // 
            this.yeniÜrünGirişiToolStripMenuItem.Name = "yeniÜrünGirişiToolStripMenuItem";
            this.yeniÜrünGirişiToolStripMenuItem.Size = new System.Drawing.Size(338, 32);
            this.yeniÜrünGirişiToolStripMenuItem.Text = "&Ekipman Bilgisini Görüntüle";
            this.yeniÜrünGirişiToolStripMenuItem.Click += new System.EventHandler(this.yeniÜrünGirişiToolStripMenuItem_Click);
            // 
            // kaleciDurumuToolStripMenuItem
            // 
            this.kaleciDurumuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KalecilerTSMI});
            this.kaleciDurumuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaleciDurumuToolStripMenuItem.Name = "kaleciDurumuToolStripMenuItem";
            this.kaleciDurumuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.kaleciDurumuToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.kaleciDurumuToolStripMenuItem.Text = "Kaleci";
            // 
            // KalecilerTSMI
            // 
            this.KalecilerTSMI.Name = "KalecilerTSMI";
            this.KalecilerTSMI.Size = new System.Drawing.Size(224, 32);
            this.KalecilerTSMI.Text = "Kaleci Düzenle";
            this.KalecilerTSMI.Click += new System.EventHandler(this.KalecilerTSMI_Click_1);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatTSMI});
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            // 
            // kapatTSMI
            // 
            this.kapatTSMI.Name = "kapatTSMI";
            this.kapatTSMI.Size = new System.Drawing.Size(224, 32);
            this.kapatTSMI.Text = "Kapat";
            this.kapatTSMI.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // DurumDgv
            // 
            this.DurumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DurumDgv.Location = new System.Drawing.Point(847, 63);
            this.DurumDgv.Name = "DurumDgv";
            this.DurumDgv.ReadOnly = true;
            this.DurumDgv.RowHeadersWidth = 51;
            this.DurumDgv.RowTemplate.Height = 24;
            this.DurumDgv.Size = new System.Drawing.Size(410, 492);
            this.DurumDgv.TabIndex = 1;
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullanıcıToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(61, 32);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // yeniKullanıcıToolStripMenuItem
            // 
            this.yeniKullanıcıToolStripMenuItem.Name = "yeniKullanıcıToolStripMenuItem";
            this.yeniKullanıcıToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.yeniKullanıcıToolStripMenuItem.Text = "Yeni Kullanıcı";
            this.yeniKullanıcıToolStripMenuItem.Click += new System.EventHandler(this.yeniKullanıcıToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::HaliSaha.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(1302, 583);
            this.Controls.Add(this.DurumDgv);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Halı Saha Takip Sistemi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurumDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonDuzenleTSMI;
        private System.Windows.Forms.ToolStripMenuItem sahaDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sahaDurumuTSMI;
        private System.Windows.Forms.ToolStripMenuItem ekipmanBilgisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaleciDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KalecilerTSMI;
        private System.Windows.Forms.DataGridView DurumDgv;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kapatTSMI;
        private System.Windows.Forms.ToolStripMenuItem yeniÜrünGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKullanıcıToolStripMenuItem;
    }
}

