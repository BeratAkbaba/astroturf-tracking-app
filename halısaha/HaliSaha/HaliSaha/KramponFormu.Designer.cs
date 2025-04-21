namespace HaliSaha
{
    partial class KramponFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KramponFormu));
            this.EkleBtn = new System.Windows.Forms.Button();
            this.IptalEtBtn = new System.Windows.Forms.Button();
            this.KramponLV = new System.Windows.Forms.ListView();
            this.ArtiBtn = new System.Windows.Forms.Button();
            this.EksiBtn = new System.Windows.Forms.Button();
            this.SayiTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EkleBtn.Location = new System.Drawing.Point(150, 165);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(133, 38);
            this.EkleBtn.TabIndex = 0;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // IptalEtBtn
            // 
            this.IptalEtBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IptalEtBtn.Location = new System.Drawing.Point(22, 165);
            this.IptalEtBtn.Name = "IptalEtBtn";
            this.IptalEtBtn.Size = new System.Drawing.Size(80, 38);
            this.IptalEtBtn.TabIndex = 6;
            this.IptalEtBtn.Text = "İptal Et";
            this.IptalEtBtn.UseVisualStyleBackColor = false;
            this.IptalEtBtn.Click += new System.EventHandler(this.IptalEtBtn_Click);
            // 
            // KramponLV
            // 
            this.KramponLV.FullRowSelect = true;
            this.KramponLV.GridLines = true;
            this.KramponLV.HideSelection = false;
            this.KramponLV.Location = new System.Drawing.Point(22, 17);
            this.KramponLV.Name = "KramponLV";
            this.KramponLV.Size = new System.Drawing.Size(261, 142);
            this.KramponLV.TabIndex = 7;
            this.KramponLV.Tag = "Krampon";
            this.KramponLV.UseCompatibleStateImageBehavior = false;
            this.KramponLV.SelectedIndexChanged += new System.EventHandler(this.KramponLV_SelectedIndexChanged);
            // 
            // ArtiBtn
            // 
            this.ArtiBtn.Enabled = false;
            this.ArtiBtn.Location = new System.Drawing.Point(289, 17);
            this.ArtiBtn.Name = "ArtiBtn";
            this.ArtiBtn.Size = new System.Drawing.Size(33, 23);
            this.ArtiBtn.TabIndex = 8;
            this.ArtiBtn.Text = "+";
            this.ArtiBtn.UseVisualStyleBackColor = true;
            this.ArtiBtn.Click += new System.EventHandler(this.ArtiBtn_Click);
            // 
            // EksiBtn
            // 
            this.EksiBtn.Enabled = false;
            this.EksiBtn.Location = new System.Drawing.Point(328, 17);
            this.EksiBtn.Name = "EksiBtn";
            this.EksiBtn.Size = new System.Drawing.Size(33, 23);
            this.EksiBtn.TabIndex = 9;
            this.EksiBtn.Text = "-";
            this.EksiBtn.UseVisualStyleBackColor = true;
            this.EksiBtn.Click += new System.EventHandler(this.EksiBtn_Click);
            // 
            // SayiTBox
            // 
            this.SayiTBox.Location = new System.Drawing.Point(289, 46);
            this.SayiTBox.Name = "SayiTBox";
            this.SayiTBox.ReadOnly = true;
            this.SayiTBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SayiTBox.Size = new System.Drawing.Size(71, 22);
            this.SayiTBox.TabIndex = 10;
            this.SayiTBox.Text = "1";
            this.SayiTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // KramponFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(396, 213);
            this.Controls.Add(this.SayiTBox);
            this.Controls.Add(this.EksiBtn);
            this.Controls.Add(this.ArtiBtn);
            this.Controls.Add(this.KramponLV);
            this.Controls.Add(this.IptalEtBtn);
            this.Controls.Add(this.EkleBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KramponFormu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KramponFormu";
            this.Load += new System.EventHandler(this.KramponFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button IptalEtBtn;
        private System.Windows.Forms.ListView KramponLV;
        private System.Windows.Forms.Button ArtiBtn;
        private System.Windows.Forms.Button EksiBtn;
        private System.Windows.Forms.TextBox SayiTBox;
    }
}