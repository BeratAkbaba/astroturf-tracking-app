namespace HaliSaha
{
    partial class SahaFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SahaFormu));
            this.RezervasyonDgv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.SahaCBox = new System.Windows.Forms.ComboBox();
            this.ZamanlayiciRezervasyon = new System.Windows.Forms.Timer(this.components);
            this.RezervasyonCbox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BilgiLbl = new System.Windows.Forms.Label();
            this.BilgiPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SoruIsareti = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonDgv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BilgiPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // RezervasyonDgv
            // 
            this.RezervasyonDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyonDgv.ContextMenuStrip = this.contextMenuStrip1;
            this.RezervasyonDgv.Location = new System.Drawing.Point(12, 137);
            this.RezervasyonDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RezervasyonDgv.Name = "RezervasyonDgv";
            this.RezervasyonDgv.RowHeadersWidth = 51;
            this.RezervasyonDgv.RowTemplate.Height = 24;
            this.RezervasyonDgv.Size = new System.Drawing.Size(1268, 358);
            this.RezervasyonDgv.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.silToolStripMenuItem.Text = "Sil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Saha:";
            // 
            // SahaCBox
            // 
            this.SahaCBox.FormattingEnabled = true;
            this.SahaCBox.Items.AddRange(new object[] {
            "<- Seçiniz ->",
            "Saha1",
            "Saha2",
            "Saha3",
            "Saha4"});
            this.SahaCBox.Location = new System.Drawing.Point(144, 90);
            this.SahaCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SahaCBox.Name = "SahaCBox";
            this.SahaCBox.Size = new System.Drawing.Size(121, 24);
            this.SahaCBox.TabIndex = 19;
            this.SahaCBox.SelectedIndexChanged += new System.EventHandler(this.SahaCBox_SelectedIndexChanged);
            // 
            // ZamanlayiciRezervasyon
            // 
            this.ZamanlayiciRezervasyon.Tick += new System.EventHandler(this.ZamanlayiciRezervasyon_Tick);
            // 
            // RezervasyonCbox
            // 
            this.RezervasyonCbox.FormattingEnabled = true;
            this.RezervasyonCbox.Items.AddRange(new object[] {
            "<-Seçiniz->",
            "Güncel",
            "Geçmiş"});
            this.RezervasyonCbox.Location = new System.Drawing.Point(144, 43);
            this.RezervasyonCbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RezervasyonCbox.Name = "RezervasyonCbox";
            this.RezervasyonCbox.Size = new System.Drawing.Size(121, 24);
            this.RezervasyonCbox.TabIndex = 21;
            this.RezervasyonCbox.SelectedIndexChanged += new System.EventHandler(this.RezervasyonCbox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Rezervasyonlar:";
            // 
            // BilgiLbl
            // 
            this.BilgiLbl.AutoSize = true;
            this.BilgiLbl.Location = new System.Drawing.Point(275, 98);
            this.BilgiLbl.Name = "BilgiLbl";
            this.BilgiLbl.Size = new System.Drawing.Size(317, 16);
            this.BilgiLbl.TabIndex = 22;
            this.BilgiLbl.Text = "Saha fiyatlandırmasında değişiklik mi yapacaksınız?";
            this.BilgiLbl.Visible = false;
            // 
            // BilgiPBox
            // 
            this.BilgiPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BilgiPBox.Image = global::HaliSaha.Properties.Resources._3994355_arrow_bottom_down_downward_navigation_icon;
            this.BilgiPBox.Location = new System.Drawing.Point(602, 93);
            this.BilgiPBox.Name = "BilgiPBox";
            this.BilgiPBox.Size = new System.Drawing.Size(27, 25);
            this.BilgiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BilgiPBox.TabIndex = 83;
            this.BilgiPBox.TabStop = false;
            this.BilgiPBox.Visible = false;
            this.BilgiPBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::HaliSaha.Properties.Resources.exit_full_screen1;
            this.pictureBox3.Location = new System.Drawing.Point(1243, 12);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // SoruIsareti
            // 
            this.SoruIsareti.AutoSize = true;
            this.SoruIsareti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SoruIsareti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoruIsareti.Location = new System.Drawing.Point(271, 95);
            this.SoruIsareti.Name = "SoruIsareti";
            this.SoruIsareti.Size = new System.Drawing.Size(17, 18);
            this.SoruIsareti.TabIndex = 84;
            this.SoruIsareti.Text = "?";
            this.SoruIsareti.Click += new System.EventHandler(this.SoruIsareti_Click);
            // 
            // SahaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1305, 519);
            this.Controls.Add(this.SoruIsareti);
            this.Controls.Add(this.BilgiPBox);
            this.Controls.Add(this.BilgiLbl);
            this.Controls.Add(this.RezervasyonCbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SahaCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RezervasyonDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SahaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SahaDurumu";
            this.Load += new System.EventHandler(this.SahaFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonDgv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BilgiPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SahaCBox;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.DataGridView RezervasyonDgv;
        private System.Windows.Forms.Timer ZamanlayiciRezervasyon;
        private System.Windows.Forms.ComboBox RezervasyonCbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BilgiLbl;
        private System.Windows.Forms.PictureBox BilgiPBox;
        private System.Windows.Forms.Label SoruIsareti;
    }
}