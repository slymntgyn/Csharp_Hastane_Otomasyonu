
namespace hastaneoto
{
    partial class HastaGirişPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaGirişPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.HastaneGirişGeri = new System.Windows.Forms.Button();
            this.HastaneGirişÜyeOl = new System.Windows.Forms.Button();
            this.HastaneGirişGiriş = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(98, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA RANDEVU MERKEZİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(69, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(153, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(153, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // HastaneGirişGeri
            // 
            this.HastaneGirişGeri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaneGirişGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaneGirişGeri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HastaneGirişGeri.Location = new System.Drawing.Point(73, 205);
            this.HastaneGirişGeri.Name = "HastaneGirişGeri";
            this.HastaneGirişGeri.Size = new System.Drawing.Size(87, 81);
            this.HastaneGirişGeri.TabIndex = 5;
            this.HastaneGirişGeri.Text = "Geri";
            this.HastaneGirişGeri.UseVisualStyleBackColor = false;
            this.HastaneGirişGeri.Click += new System.EventHandler(this.HastaneGirişGeri_Click);
            // 
            // HastaneGirişÜyeOl
            // 
            this.HastaneGirişÜyeOl.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaneGirişÜyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaneGirişÜyeOl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HastaneGirişÜyeOl.Location = new System.Drawing.Point(214, 205);
            this.HastaneGirişÜyeOl.Name = "HastaneGirişÜyeOl";
            this.HastaneGirişÜyeOl.Size = new System.Drawing.Size(84, 81);
            this.HastaneGirişÜyeOl.TabIndex = 6;
            this.HastaneGirişÜyeOl.Text = "Üye Ol";
            this.HastaneGirişÜyeOl.UseVisualStyleBackColor = false;
            this.HastaneGirişÜyeOl.Click += new System.EventHandler(this.HastaneGirişÜyeOl_Click);
            // 
            // HastaneGirişGiriş
            // 
            this.HastaneGirişGiriş.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaneGirişGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaneGirişGiriş.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.HastaneGirişGiriş.Location = new System.Drawing.Point(351, 205);
            this.HastaneGirişGiriş.Name = "HastaneGirişGiriş";
            this.HastaneGirişGiriş.Size = new System.Drawing.Size(82, 81);
            this.HastaneGirişGiriş.TabIndex = 7;
            this.HastaneGirişGiriş.Text = "Giriş";
            this.HastaneGirişGiriş.UseVisualStyleBackColor = false;
            this.HastaneGirişGiriş.Click += new System.EventHandler(this.HastaneGirişGiriş_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox1.Location = new System.Drawing.Point(407, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // HastaGirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(500, 309);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.HastaneGirişGiriş);
            this.Controls.Add(this.HastaneGirişÜyeOl);
            this.Controls.Add(this.HastaneGirişGeri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HastaGirişPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Paneli";
            this.Load += new System.EventHandler(this.HastaGirişPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button HastaneGirişGeri;
        private System.Windows.Forms.Button HastaneGirişÜyeOl;
        private System.Windows.Forms.Button HastaneGirişGiriş;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}