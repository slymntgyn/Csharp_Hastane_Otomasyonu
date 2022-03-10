
namespace hastaneoto
{
    partial class AdminGirişPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGirişPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKadi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.AdminGeri = new System.Windows.Forms.Button();
            this.AdminGiriş = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(128, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMİN GİRİŞ PANELİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(43, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // textBoxKadi
            // 
            this.textBoxKadi.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxKadi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxKadi.Location = new System.Drawing.Point(116, 78);
            this.textBoxKadi.Name = "textBoxKadi";
            this.textBoxKadi.Size = new System.Drawing.Size(251, 29);
            this.textBoxKadi.TabIndex = 3;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSifre.Location = new System.Drawing.Point(116, 134);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(251, 29);
            this.textBoxSifre.TabIndex = 4;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // AdminGeri
            // 
            this.AdminGeri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminGeri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AdminGeri.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AdminGeri.Location = new System.Drawing.Point(60, 202);
            this.AdminGeri.Name = "AdminGeri";
            this.AdminGeri.Size = new System.Drawing.Size(109, 59);
            this.AdminGeri.TabIndex = 5;
            this.AdminGeri.Text = "Geri";
            this.AdminGeri.UseVisualStyleBackColor = false;
            this.AdminGeri.Click += new System.EventHandler(this.AdminGeri_Click);
            // 
            // AdminGiriş
            // 
            this.AdminGiriş.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AdminGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminGiriş.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AdminGiriş.Location = new System.Drawing.Point(290, 202);
            this.AdminGiriş.Name = "AdminGiriş";
            this.AdminGiriş.Size = new System.Drawing.Size(119, 59);
            this.AdminGiriş.TabIndex = 6;
            this.AdminGiriş.Text = "Giriş";
            this.AdminGiriş.UseVisualStyleBackColor = false;
            this.AdminGiriş.Click += new System.EventHandler(this.AdminGiriş_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(378, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // AdminGirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 279);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AdminGiriş);
            this.Controls.Add(this.AdminGeri);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGirişPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Giriş Paneli";
            this.Load += new System.EventHandler(this.AdminGirişPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKadi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button AdminGeri;
        private System.Windows.Forms.Button AdminGiriş;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}