namespace OOPDevam_1
{
    partial class Form1
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
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.BtnYarat = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 16;
            this.LstSonuc.Location = new System.Drawing.Point(21, 142);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(411, 308);
            this.LstSonuc.TabIndex = 0;
            this.LstSonuc.Click += new System.EventHandler(this.LstSonuc_Click);
            // 
            // BtnYarat
            // 
            this.BtnYarat.Location = new System.Drawing.Point(21, 77);
            this.BtnYarat.Name = "BtnYarat";
            this.BtnYarat.Size = new System.Drawing.Size(75, 23);
            this.BtnYarat.TabIndex = 1;
            this.BtnYarat.Text = "Yarat";
            this.BtnYarat.UseVisualStyleBackColor = true;
            this.BtnYarat.Click += new System.EventHandler(this.BtnYarat_Click);
            // 
            // LblSonuc
            // 
            this.LblSonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSonuc.Location = new System.Drawing.Point(482, 174);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(196, 23);
            this.LblSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 533);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnYarat);
            this.Controls.Add(this.LstSonuc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstSonuc;
        private System.Windows.Forms.Button BtnYarat;
        private System.Windows.Forms.Label LblSonuc;
    }
}

