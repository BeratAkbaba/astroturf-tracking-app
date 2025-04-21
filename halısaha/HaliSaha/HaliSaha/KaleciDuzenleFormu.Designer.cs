namespace HaliSaha
{
    partial class KaleciDuzenleFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KaleciDuzenleFormu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.MevcutCBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.kaydetBtn = new System.Windows.Forms.Button();
            this.TelTBox = new System.Windows.Forms.TextBox();
            this.adTBox = new System.Windows.Forms.TextBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.YasTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FiyatTBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.KaleciFormSplitC = new System.Windows.Forms.SplitContainer();
            this.KPanel = new System.Windows.Forms.Panel();
            this.GuncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KaleciFormSplitC)).BeginInit();
            this.KaleciFormSplitC.Panel1.SuspendLayout();
            this.KaleciFormSplitC.Panel2.SuspendLayout();
            this.KaleciFormSplitC.SuspendLayout();
            this.KPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(29, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(643, 264);
            this.dataGridView1.TabIndex = 7;
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
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 95;
            this.label8.Text = "Mevcutluk Durumu:";
            // 
            // MevcutCBox
            // 
            this.MevcutCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MevcutCBox.FormattingEnabled = true;
            this.MevcutCBox.Location = new System.Drawing.Point(158, 248);
            this.MevcutCBox.Name = "MevcutCBox";
            this.MevcutCBox.Size = new System.Drawing.Size(131, 24);
            this.MevcutCBox.TabIndex = 3;
            this.MevcutCBox.SelectedIndexChanged += new System.EventHandler(this.MevcutCBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 89;
            this.label5.Text = "Telefon Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 85;
            this.label1.Text = "Kaleci Adı Soyadı:";
            // 
            // iptalBtn
            // 
            this.iptalBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iptalBtn.Location = new System.Drawing.Point(158, 345);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(81, 35);
            this.iptalBtn.TabIndex = 5;
            this.iptalBtn.Text = "İptal Et";
            this.iptalBtn.UseVisualStyleBackColor = false;
            this.iptalBtn.Click += new System.EventHandler(this.iptalBtn_Click);
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kaydetBtn.Location = new System.Drawing.Point(243, 345);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(81, 35);
            this.kaydetBtn.TabIndex = 4;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.UseVisualStyleBackColor = false;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // TelTBox
            // 
            this.TelTBox.Location = new System.Drawing.Point(149, 109);
            this.TelTBox.Name = "TelTBox";
            this.TelTBox.Size = new System.Drawing.Size(129, 22);
            this.TelTBox.TabIndex = 2;
            // 
            // adTBox
            // 
            this.adTBox.Location = new System.Drawing.Point(149, 14);
            this.adTBox.Name = "adTBox";
            this.adTBox.Size = new System.Drawing.Size(131, 22);
            this.adTBox.TabIndex = 0;
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EkleBtn.Location = new System.Drawing.Point(571, 345);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(101, 39);
            this.EkleBtn.TabIndex = 8;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 103;
            this.label2.Text = "Yaş:";
            // 
            // YasTBox
            // 
            this.YasTBox.Location = new System.Drawing.Point(149, 64);
            this.YasTBox.Name = "YasTBox";
            this.YasTBox.Size = new System.Drawing.Size(131, 22);
            this.YasTBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 106;
            this.label3.Text = "Fiyat";
            // 
            // FiyatTBox
            // 
            this.FiyatTBox.Location = new System.Drawing.Point(158, 289);
            this.FiyatTBox.Name = "FiyatTBox";
            this.FiyatTBox.Size = new System.Drawing.Size(129, 22);
            this.FiyatTBox.TabIndex = 105;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = global::HaliSaha.Properties.Resources.exit_full_screen1;
            this.pictureBox3.Location = new System.Drawing.Point(621, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 104;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // KaleciFormSplitC
            // 
            this.KaleciFormSplitC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KaleciFormSplitC.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.KaleciFormSplitC.IsSplitterFixed = true;
            this.KaleciFormSplitC.Location = new System.Drawing.Point(0, 0);
            this.KaleciFormSplitC.Name = "KaleciFormSplitC";
            // 
            // KaleciFormSplitC.Panel1
            // 
            this.KaleciFormSplitC.Panel1.Controls.Add(this.KPanel);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.GuncelleBtn);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.label3);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.FiyatTBox);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.kaydetBtn);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.iptalBtn);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.MevcutCBox);
            this.KaleciFormSplitC.Panel1.Controls.Add(this.label8);
            this.KaleciFormSplitC.Panel1MinSize = 250;
            // 
            // KaleciFormSplitC.Panel2
            // 
            this.KaleciFormSplitC.Panel2.Controls.Add(this.dataGridView1);
            this.KaleciFormSplitC.Panel2.Controls.Add(this.EkleBtn);
            this.KaleciFormSplitC.Panel2.Controls.Add(this.pictureBox3);
            this.KaleciFormSplitC.Panel2MinSize = 0;
            this.KaleciFormSplitC.Size = new System.Drawing.Size(1035, 403);
            this.KaleciFormSplitC.SplitterDistance = 345;
            this.KaleciFormSplitC.TabIndex = 107;
            // 
            // KPanel
            // 
            this.KPanel.Controls.Add(this.label1);
            this.KPanel.Controls.Add(this.YasTBox);
            this.KPanel.Controls.Add(this.adTBox);
            this.KPanel.Controls.Add(this.label2);
            this.KPanel.Controls.Add(this.label5);
            this.KPanel.Controls.Add(this.TelTBox);
            this.KPanel.Location = new System.Drawing.Point(12, 91);
            this.KPanel.Name = "KPanel";
            this.KPanel.Size = new System.Drawing.Size(325, 151);
            this.KPanel.TabIndex = 108;
            this.KPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.KPanel_Paint);
            // 
            // GuncelleBtn
            // 
            this.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GuncelleBtn.Location = new System.Drawing.Point(243, 345);
            this.GuncelleBtn.Name = "GuncelleBtn";
            this.GuncelleBtn.Size = new System.Drawing.Size(81, 35);
            this.GuncelleBtn.TabIndex = 107;
            this.GuncelleBtn.Text = "Güncelle";
            this.GuncelleBtn.UseVisualStyleBackColor = false;
            this.GuncelleBtn.Visible = false;
            this.GuncelleBtn.Click += new System.EventHandler(this.GuncelleBtn_Click);
            // 
            // KaleciDuzenleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1035, 403);
            this.Controls.Add(this.KaleciFormSplitC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KaleciDuzenleFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.KaleciDuzenleFormu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.KaleciFormSplitC.Panel1.ResumeLayout(false);
            this.KaleciFormSplitC.Panel1.PerformLayout();
            this.KaleciFormSplitC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.KaleciFormSplitC)).EndInit();
            this.KaleciFormSplitC.ResumeLayout(false);
            this.KPanel.ResumeLayout(false);
            this.KPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MevcutCBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button kaydetBtn;
        private System.Windows.Forms.TextBox TelTBox;
        private System.Windows.Forms.TextBox adTBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox YasTBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FiyatTBox;
        public System.Windows.Forms.SplitContainer KaleciFormSplitC;
        public System.Windows.Forms.Button GuncelleBtn;
        private System.Windows.Forms.Panel KPanel;
    }
}