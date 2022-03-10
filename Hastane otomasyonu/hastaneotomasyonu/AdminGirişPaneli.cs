using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace hastaneoto
{
    public partial class AdminGirişPaneli : Form 
    {
       

        public AdminGirişPaneli()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminGeri_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.formAnaEkran.Show(); // anaekran formumuzu gösterip
            this.Hide(); // şuan bulunan admin giriş formumuzu gizliyoruz.
        }
        
        private void AdminGiriş_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBoxKadi.Text != "" && textBoxSifre.Text != "")
            {
                try
                {
                    
                    baglanti.Open();
                    string sql = "select * from admin where kullaniciAdi=@kadi and sifre=@sifre";
                    SqlParameter prm1 = new SqlParameter("@kadi", textBoxKadi.Text);
                    SqlParameter prm2 = new SqlParameter("@sifre", textBoxSifre.Text);

                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.Add(prm1);
                    komut.Parameters.Add(prm2);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(komut);
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        AdminEkranı ae = new AdminEkranı();
                        ae.Show();
                        textBoxKadi.Clear();
                        textBoxSifre.Clear();

                        this.Hide(); // bu formu gizledik
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız !!!", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBoxSifre.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
        }

        private void AdminGirişPaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
