namespace HaliSaha
{
    partial class EkipmanBilgisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EkipmanBilgisi));
            this.label1 = new System.Windows.Forms.Label();
            this.NumaraLbl = new System.Windows.Forms.Label();
            this.urunAdiCBox = new System.Windows.Forms.ComboBox();
            this.NumaraTBox = new System.Windows.Forms.TextBox();
            this.MiktarTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CıkısPBox = new System.Windows.Forms.PictureBox();
            this.MarkaCBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FiyatTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CıkısPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // NumaraLbl
            // 
            this.NumaraLbl.AutoSize = true;
            this.NumaraLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NumaraLbl.Location = new System.Drawing.Point(19, 246);
            this.NumaraLbl.Name = "NumaraLbl";
            this.NumaraLbl.Size = new System.Drawing.Size(67, 19);
            this.NumaraLbl.TabIndex = 1;
            this.NumaraLbl.Text = "Numara:";
            // 
            // urunAdiCBox
            // 
            this.urunAdiCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.urunAdiCBox.FormattingEnabled = true;
            this.urunAdiCBox.Items.AddRange(new object[] {
            "Krampon\t",
            "Eldiven"});
            this.urunAdiCBox.Location = new System.Drawing.Point(94, 68);
            this.urunAdiCBox.Name = "urunAdiCBox";
            this.urunAdiCBox.Size = new System.Drawing.Size(121, 24);
            this.urunAdiCBox.TabIndex = 0;
            // 
            // NumaraTBox
            // 
            this.NumaraTBox.Location = new System.Drawing.Point(97, 246);
            this.NumaraTBox.Name = "NumaraTBox";
            this.NumaraTBox.Size = new System.Drawing.Size(121, 22);
            this.NumaraTBox.TabIndex = 4;
            // 
            // MiktarTBox
            // 
            this.MiktarTBox.Location = new System.Drawing.Point(97, 113);
            this.MiktarTBox.Name = "MiktarTBox";
            this.MiktarTBox.Size = new System.Drawing.Size(121, 22);
            this.MiktarTBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Miktar";
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EkleBtn.Location = new System.Drawing.Point(140, 291);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(75, 33);
            this.EkleBtn.TabIndex = 5;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(254, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 256);
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
            // CıkısPBox
            // 
            this.CıkısPBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CıkısPBox.Image = global::HaliSaha.Properties.Resources.exit_full_screen1;
            this.CıkısPBox.Location = new System.Drawing.Point(719, 12);
            this.CıkısPBox.Name = "CıkısPBox";
            this.CıkısPBox.Size = new System.Drawing.Size(51, 50);
            this.CıkısPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CıkısPBox.TabIndex = 8;
            this.CıkısPBox.TabStop = false;
            this.CıkısPBox.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MarkaCBox
            // 
            this.MarkaCBox.FormattingEnabled = true;
            this.MarkaCBox.Location = new System.Drawing.Point(97, 161);
            this.MarkaCBox.Name = "MarkaCBox";
            this.MarkaCBox.Size = new System.Drawing.Size(121, 24);
            this.MarkaCBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marka:";
            // 
            // FiyatTBox
            // 
            this.FiyatTBox.Location = new System.Drawing.Point(97, 204);
            this.FiyatTBox.Name = "FiyatTBox";
            this.FiyatTBox.Size = new System.Drawing.Size(121, 22);
            this.FiyatTBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fiyat:";
            // 
            // EkipmanBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 349);
            this.Controls.Add(this.FiyatTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarkaCBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CıkısPBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EkleBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MiktarTBox);
            this.Controls.Add(this.NumaraTBox);
            this.Controls.Add(this.urunAdiCBox);
            this.Controls.Add(this.NumaraLbl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EkipmanBilgisi";
            this.Text = "Ekipman Bilgi Formu";
            this.Load += new System.EventHandler(this.EkipmanBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CıkısPBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumaraLbl;
        private System.Windows.Forms.ComboBox urunAdiCBox;
        private System.Windows.Forms.TextBox NumaraTBox;
        private System.Windows.Forms.TextBox MiktarTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.PictureBox CıkısPBox;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ComboBox MarkaCBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FiyatTBox;
        private System.Windows.Forms.Label label2;
    }
}