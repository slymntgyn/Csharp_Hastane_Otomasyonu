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
    public partial class DoktorGirişEkranı : Form
    {
        public DoktorGirişEkranı()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DoktorGeri_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.formAnaEkran.Show(); // anaekran formumuzu gösterip
            this.Hide(); // şuan bulunan admin giriş formumuzu gizliyoruz.
        }

        private void DoktorGiriş_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            try
            {
                baglanti.Open();
                string sql = "select * from doktor where kullanciAdi=@kadi and sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("@kadi", textBox1.Text);
                SqlParameter prm2 = new SqlParameter("@sifre", textBox2.Text);

                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Doktorrandevuları dr = new Doktorrandevuları();
                    dr.Show();
                    textBox1.Clear();
                    textBox2.Clear();

                    this.Hide();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void DoktorGirişEkranı_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
