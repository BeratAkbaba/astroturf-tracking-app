namespace HaliSaha
{
    partial class EldivenFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EldivenFormu));
            this.IptalEtBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.SayiTBox = new System.Windows.Forms.TextBox();
            this.EksiBtn = new System.Windows.Forms.Button();
            this.ArtiBtn = new System.Windows.Forms.Button();
            this.EldivenLV = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // IptalEtBtn
            // 
            this.IptalEtBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IptalEtBtn.Location = new System.Drawing.Point(33, 189);
            this.IptalEtBtn.Name = "IptalEtBtn";
            this.IptalEtBtn.Size = new System.Drawing.Size(67, 38);
            this.IptalEtBtn.TabIndex = 11;
            this.IptalEtBtn.Text = "İptal Et";
            this.IptalEtBtn.UseVisualStyleBackColor = false;
            this.IptalEtBtn.Click += new System.EventHandler(this.IptalEtBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EkleBtn.Location = new System.Drawing.Point(167, 189);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(127, 38);
            this.EkleBtn.TabIndex = 7;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // SayiTBox
            // 
            this.SayiTBox.Enabled = false;
            this.SayiTBox.Location = new System.Drawing.Point(300, 60);
            this.SayiTBox.Name = "SayiTBox";
            this.SayiTBox.ReadOnly = true;
            this.SayiTBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SayiTBox.Size = new System.Drawing.Size(71, 22);
            this.SayiTBox.TabIndex = 15;
            this.SayiTBox.Text = "1";
            this.SayiTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EksiBtn
            // 
            this.EksiBtn.Enabled = false;
            this.EksiBtn.Location = new System.Drawing.Point(339, 31);
            this.EksiBtn.Name = "EksiBtn";
            this.EksiBtn.Size = new System.Drawing.Size(33, 23);
            this.EksiBtn.TabIndex = 14;
            this.EksiBtn.Text = "-";
            this.EksiBtn.UseVisualStyleBackColor = true;
            this.EksiBtn.Click += new System.EventHandler(this.EksiBtn_Click);
            // 
            // ArtiBtn
            // 
            this.ArtiBtn.Enabled = false;
            this.ArtiBtn.Location = new System.Drawing.Point(300, 31);
            this.ArtiBtn.Name = "ArtiBtn";
            this.ArtiBtn.Size = new System.Drawing.Size(33, 23);
            this.ArtiBtn.TabIndex = 13;
            this.ArtiBtn.Text = "+";
            this.ArtiBtn.UseVisualStyleBackColor = true;
            this.ArtiBtn.Click += new System.EventHandler(this.ArtiBtn_Click);
            // 
            // EldivenLV
            // 
            this.EldivenLV.FullRowSelect = true;
            this.EldivenLV.GridLines = true;
            this.EldivenLV.HideSelection = false;
            this.EldivenLV.Location = new System.Drawing.Point(33, 31);
            this.EldivenLV.Name = "EldivenLV";
            this.EldivenLV.Size = new System.Drawing.Size(261, 142);
            this.EldivenLV.TabIndex = 12;
            this.EldivenLV.Tag = "Eldiven";
            this.EldivenLV.UseCompatibleStateImageBehavior = false;
            this.EldivenLV.SelectedIndexChanged += new System.EventHandler(this.EldivenLV_SelectedIndexChanged_1);
            // 
            // EldivenFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(397, 244);
            this.Controls.Add(this.SayiTBox);
            this.Controls.Add(this.EksiBtn);
            this.Controls.Add(this.ArtiBtn);
            this.Controls.Add(this.EldivenLV);
            this.Controls.Add(this.IptalEtBtn);
            this.Controls.Add(this.EkleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EldivenFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EldivenFormu";
            this.Load += new System.EventHandler(this.EldivenFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IptalEtBtn;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.TextBox SayiTBox;
        private System.Windows.Forms.Button EksiBtn;
        private System.Windows.Forms.Button ArtiBtn;
        private System.Windows.Forms.ListView EldivenLV;
    }
}