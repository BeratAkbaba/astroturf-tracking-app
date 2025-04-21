namespace HaliSaha
{
    partial class SahaFiyatlandırmaFormu
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
            this.SahaCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiyatTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.SahaCBox.Location = new System.Drawing.Point(146, 42);
            this.SahaCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SahaCBox.Name = "SahaCBox";
            this.SahaCBox.Size = new System.Drawing.Size(121, 24);
            this.SahaCBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Saha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 22;
            this.label1.Text = "Yeni Fiyat";
            // 
            // FiyatTBox
            // 
            this.FiyatTBox.Location = new System.Drawing.Point(146, 90);
            this.FiyatTBox.Name = "FiyatTBox";
            this.FiyatTBox.Size = new System.Drawing.Size(121, 22);
            this.FiyatTBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Burada uygulayacağınız tarife bir sonraki\r\nrezervasyon için geçerli olacaktır.";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.KaydetBtn.Location = new System.Drawing.Point(279, 185);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(88, 31);
            this.KaydetBtn.TabIndex = 25;
            this.KaydetBtn.Text = "Kaydet";
            this.KaydetBtn.UseVisualStyleBackColor = false;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // SahaFiyatlandırmaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(382, 228);
            this.Controls.Add(this.KaydetBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiyatTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SahaCBox);
            this.Controls.Add(this.label2);
            this.Name = "SahaFiyatlandırmaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SahaFiyatlandırmaFormu";
            this.Load += new System.EventHandler(this.SahaFiyatlandırmaFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SahaCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FiyatTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button KaydetBtn;
    }
}