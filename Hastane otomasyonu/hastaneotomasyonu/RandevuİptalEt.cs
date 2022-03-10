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
    public partial class RandevuİptalEt : Form
    {
        

        public RandevuİptalEt()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.ranndevual.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string silmesorgu = "DELETE from randevu where TC=@hastaıd";
                    SqlCommand silmekomut = new SqlCommand(silmesorgu,baglanti);
                    silmekomut.Parameters.AddWithValue("@hastaıd",textBox1.Text);

                    silmekomut.ExecuteNonQuery();
                    MessageBox.Show("Randevu İptal edilmiştir.");
                    
                    baglanti.Close();
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız !", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void RandevuİptalEt_Load(object sender, EventArgs e)
        {

        }
    }
}
