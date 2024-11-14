namespace OOPDevam_1
{
    partial class Form2
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
            this.LstEgitmenler = new System.Windows.Forms.ListBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtSoyIsim = new System.Windows.Forms.TextBox();
            this.LstBranslar = new System.Windows.Forms.ListBox();
            this.BtnEgitmenEkle = new System.Windows.Forms.Button();
            this.LblEgitmen = new System.Windows.Forms.Label();
            this.TxtBrans = new System.Windows.Forms.TextBox();
            this.BtnBransEkle = new System.Windows.Forms.Button();
            this.LblBrans = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstEgitmenler
            // 
            this.LstEgitmenler.FormattingEnabled = true;
            this.LstEgitmenler.ItemHeight = 16;
            this.LstEgitmenler.Location = new System.Drawing.Point(23, 56);
            this.LstEgitmenler.Name = "LstEgitmenler";
            this.LstEgitmenler.Size = new System.Drawing.Size(290, 404);
            this.LstEgitmenler.TabIndex = 0;
            this.LstEgitmenler.Click += new System.EventHandler(this.LstEgitmenler_Click);
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(23, 476);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtIsim.TabIndex = 1;
            // 
            // TxtSoyIsim
            // 
            this.TxtSoyIsim.Location = new System.Drawing.Point(23, 516);
            this.TxtSoyIsim.Name = "TxtSoyIsim";
            this.TxtSoyIsim.Size = new System.Drawing.Size(100, 22);
            this.TxtSoyIsim.TabIndex = 1;
            // 
            // LstBranslar
            // 
            this.LstBranslar.FormattingEnabled = true;
            this.LstBranslar.ItemHeight = 16;
            this.LstBranslar.Location = new System.Drawing.Point(709, 56);
            this.LstBranslar.Name = "LstBranslar";
            this.LstBranslar.Size = new System.Drawing.Size(290, 404);
            this.LstBranslar.TabIndex = 0;
            this.LstBranslar.Click += new System.EventHandler(this.LstBranslar_Click);
            // 
            // BtnEgitmenEkle
            // 
            this.BtnEgitmenEkle.Location = new System.Drawing.Point(23, 561);
            this.BtnEgitmenEkle.Name = "BtnEgitmenEkle";
            this.BtnEgitmenEkle.Size = new System.Drawing.Size(147, 37);
            this.BtnEgitmenEkle.TabIndex = 2;
            this.BtnEgitmenEkle.Text = "Egitmen Ekle";
            this.BtnEgitmenEkle.UseVisualStyleBackColor = true;
            this.BtnEgitmenEkle.Click += new System.EventHandler(this.BtnEgitmenEkle_Click);
            // 
            // LblEgitmen
            // 
            this.LblEgitmen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEgitmen.Location = new System.Drawing.Point(350, 118);
            this.LblEgitmen.Name = "LblEgitmen";
            this.LblEgitmen.Size = new System.Drawing.Size(293, 115);
            this.LblEgitmen.TabIndex = 3;
            // 
            // TxtBrans
            // 
            this.TxtBrans.Location = new System.Drawing.Point(709, 493);
            this.TxtBrans.Name = "TxtBrans";
            this.TxtBrans.Size = new System.Drawing.Size(222, 22);
            this.TxtBrans.TabIndex = 4;
            // 
            // BtnBransEkle
            // 
            this.BtnBransEkle.Location = new System.Drawing.Point(709, 551);
            this.BtnBransEkle.Name = "BtnBransEkle";
            this.BtnBransEkle.Size = new System.Drawing.Size(129, 23);
            this.BtnBransEkle.TabIndex = 5;
            this.BtnBransEkle.Text = "Brans Ekle";
            this.BtnBransEkle.UseVisualStyleBackColor = true;
            this.BtnBransEkle.Click += new System.EventHandler(this.BtnBransEkle_Click);
            // 
            // LblBrans
            // 
            this.LblBrans.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblBrans.Location = new System.Drawing.Point(1041, 118);
            this.LblBrans.Name = "LblBrans";
            this.LblBrans.Size = new System.Drawing.Size(236, 115);
            this.LblBrans.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(406, 296);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 675);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.BtnBransEkle);
            this.Controls.Add(this.TxtBrans);
            this.Controls.Add(this.LblBrans);
            this.Controls.Add(this.LblEgitmen);
            this.Controls.Add(this.BtnEgitmenEkle);
            this.Controls.Add(this.TxtSoyIsim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.LstBranslar);
            this.Controls.Add(this.LstEgitmenler);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstEgitmenler;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtSoyIsim;
        private System.Windows.Forms.ListBox LstBranslar;
        private System.Windows.Forms.Button BtnEgitmenEkle;
        private System.Windows.Forms.Label LblEgitmen;
        private System.Windows.Forms.TextBox TxtBrans;
        private System.Windows.Forms.Button BtnBransEkle;
        private System.Windows.Forms.Label LblBrans;
        private System.Windows.Forms.Button btnEkle;
    }
}