
namespace hastaneoto
{
    partial class AdminEkranı
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
            System.Windows.Forms.Button doktorekle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkranı));
            this.label1 = new System.Windows.Forms.Label();
            this.KLİNİKEKLE = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            doktorekle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorekle
            // 
            doktorekle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            doktorekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            doktorekle.Location = new System.Drawing.Point(27, 113);
            doktorekle.Name = "doktorekle";
            doktorekle.Size = new System.Drawing.Size(342, 32);
            doktorekle.TabIndex = 1;
            doktorekle.Text = "DOKTOR EKLE-SİL";
            doktorekle.UseVisualStyleBackColor = false;
            doktorekle.Click += new System.EventHandler(this.doktorekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞ GELDİN ADMİN";
            // 
            // KLİNİKEKLE
            // 
            this.KLİNİKEKLE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.KLİNİKEKLE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KLİNİKEKLE.Location = new System.Drawing.Point(27, 151);
            this.KLİNİKEKLE.Name = "KLİNİKEKLE";
            this.KLİNİKEKLE.Size = new System.Drawing.Size(342, 36);
            this.KLİNİKEKLE.TabIndex = 2;
            this.KLİNİKEKLE.Text = "KLİNİK EKLE-SİL";
            this.KLİNİKEKLE.UseVisualStyleBackColor = false;
            this.KLİNİKEKLE.Click += new System.EventHandler(this.KLİNİKEKLE_Click);
            // 
            // geri
            // 
            this.geri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.geri.Location = new System.Drawing.Point(27, 284);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(342, 39);
            this.geri.TabIndex = 3;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = false;
            this.geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(27, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(342, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "HASTANE EKLE-SİL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(27, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(342, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "ADMİN EKLE-SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdminEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.KLİNİKEKLE);
            this.Controls.Add(doktorekle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Ekranı";
            this.Load += new System.EventHandler(this.AdminEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KLİNİKEKLE;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}