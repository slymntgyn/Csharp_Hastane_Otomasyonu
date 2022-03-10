
namespace hastaneoto
{
    partial class DoktorGirişEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorGirişEkranı));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DoktorGeri = new System.Windows.Forms.Button();
            this.DoktorGiriş = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(141, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kullanıcı Adı :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(55, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox1.Location = new System.Drawing.Point(124, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 29);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(124, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 29);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DoktorGeri
            // 
            this.DoktorGeri.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoktorGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoktorGeri.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DoktorGeri.Location = new System.Drawing.Point(73, 202);
            this.DoktorGeri.Name = "DoktorGeri";
            this.DoktorGeri.Size = new System.Drawing.Size(92, 52);
            this.DoktorGeri.TabIndex = 5;
            this.DoktorGeri.Text = "Geri";
            this.DoktorGeri.UseVisualStyleBackColor = false;
            this.DoktorGeri.Click += new System.EventHandler(this.DoktorGeri_Click);
            // 
            // DoktorGiriş
            // 
            this.DoktorGiriş.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DoktorGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoktorGiriş.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DoktorGiriş.Location = new System.Drawing.Point(252, 202);
            this.DoktorGiriş.Name = "DoktorGiriş";
            this.DoktorGiriş.Size = new System.Drawing.Size(96, 52);
            this.DoktorGiriş.TabIndex = 6;
            this.DoktorGiriş.Text = "Giriş";
            this.DoktorGiriş.UseVisualStyleBackColor = false;
            this.DoktorGiriş.Click += new System.EventHandler(this.DoktorGiriş_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(364, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Şifreyi Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DoktorGirişEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 282);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DoktorGiriş);
            this.Controls.Add(this.DoktorGeri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoktorGirişEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Ekranı";
            this.Load += new System.EventHandler(this.DoktorGirişEkranı_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button DoktorGeri;
        private System.Windows.Forms.Button DoktorGiriş;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}