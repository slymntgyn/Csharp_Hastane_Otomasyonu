
namespace hastaneoto
{
    partial class Anaekran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anaekran));
            this.AnaAdminGiriş = new System.Windows.Forms.Button();
            this.AnaDoktorGiriş = new System.Windows.Forms.Button();
            this.AnaHastaGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnaAdminGiriş
            // 
            this.AnaAdminGiriş.BackColor = System.Drawing.Color.SteelBlue;
            this.AnaAdminGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaAdminGiriş.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AnaAdminGiriş.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AnaAdminGiriş.Image = ((System.Drawing.Image)(resources.GetObject("AnaAdminGiriş.Image")));
            this.AnaAdminGiriş.Location = new System.Drawing.Point(9, 88);
            this.AnaAdminGiriş.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.AnaAdminGiriş.Name = "AnaAdminGiriş";
            this.AnaAdminGiriş.Size = new System.Drawing.Size(141, 81);
            this.AnaAdminGiriş.TabIndex = 1;
            this.AnaAdminGiriş.UseVisualStyleBackColor = false;
            this.AnaAdminGiriş.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaDoktorGiriş
            // 
            this.AnaDoktorGiriş.BackColor = System.Drawing.Color.SteelBlue;
            this.AnaDoktorGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaDoktorGiriş.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AnaDoktorGiriş.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AnaDoktorGiriş.Image = ((System.Drawing.Image)(resources.GetObject("AnaDoktorGiriş.Image")));
            this.AnaDoktorGiriş.Location = new System.Drawing.Point(184, 88);
            this.AnaDoktorGiriş.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.AnaDoktorGiriş.Name = "AnaDoktorGiriş";
            this.AnaDoktorGiriş.Size = new System.Drawing.Size(139, 81);
            this.AnaDoktorGiriş.TabIndex = 2;
            this.AnaDoktorGiriş.UseVisualStyleBackColor = false;
            this.AnaDoktorGiriş.Click += new System.EventHandler(this.button2_Click);
            // 
            // AnaHastaGiriş
            // 
            this.AnaHastaGiriş.BackColor = System.Drawing.Color.SteelBlue;
            this.AnaHastaGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnaHastaGiriş.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.AnaHastaGiriş.ForeColor = System.Drawing.SystemColors.MenuText;
            this.AnaHastaGiriş.Image = ((System.Drawing.Image)(resources.GetObject("AnaHastaGiriş.Image")));
            this.AnaHastaGiriş.Location = new System.Drawing.Point(357, 88);
            this.AnaHastaGiriş.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.AnaHastaGiriş.Name = "AnaHastaGiriş";
            this.AnaHastaGiriş.Size = new System.Drawing.Size(138, 81);
            this.AnaHastaGiriş.TabIndex = 3;
            this.AnaHastaGiriş.UseVisualStyleBackColor = false;
            this.AnaHastaGiriş.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.85F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "HASTANE RANDEVU MERKEZİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(25, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Admin Giriş";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(194, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Doktor Giriş";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(378, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta Giriş";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(380, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Otomasyonu Kapat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Anaekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnaHastaGiriş);
            this.Controls.Add(this.AnaDoktorGiriş);
            this.Controls.Add(this.AnaAdminGiriş);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.Name = "Anaekran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.anaekran_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnaAdminGiriş;
        private System.Windows.Forms.Button AnaDoktorGiriş;
        private System.Windows.Forms.Button AnaHastaGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}