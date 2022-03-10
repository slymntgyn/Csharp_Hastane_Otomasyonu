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
    public partial class KlinikEkleSil : Form
    {
        

        public KlinikEkleSil()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.adminekranı.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if ( textBox2.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into klinik (klinikAdi) Values(@klinikadi)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    
                    komut.Parameters.AddWithValue("@klinikadi", textBox2.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni klinik başarı ile eklenmiştir.");
                    baglanti.Close();
                    
                    textBox2.Clear();
                    klinikgetir();

                }
                catch (Exception)
                {

                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

                try
                {
                    baglanti.Open();
                    string silmesorgu = "DELETE from klinik where klinikAdi=@klinikıd";
                    SqlCommand silmekomut = new SqlCommand(silmesorgu, baglanti);
                    silmekomut.Parameters.AddWithValue("@klinikıd", dataGridView1.CurrentRow.Cells[1].Value.ToString());

                    silmekomut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi başarıyla sonuçlanmıştır.");
                    baglanti.Close();
                    
                    textBox2.Clear();
                klinikgetir();
                }
                catch (Exception )
                {
                    /*Mesaj düzenlenecek*/
                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            
            
        }
        void klinikgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from klinik",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void KlinikEkleSil_Load(object sender, EventArgs e)
        {
            klinikgetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if ( textBox2.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Update klinik Set klinikAdi=@kadi where  klinikID=@kid  ";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kid", textBox1.Text);
                    komut.Parameters.AddWithValue("@kadi", textBox2.Text);
                    

                    komut.ExecuteNonQuery();
                    MessageBox.Show("klinik başarı ile Güncellenmiştir.");
                    baglanti.Close();
                    
                    textBox2.Clear();
                    klinikgetir();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
