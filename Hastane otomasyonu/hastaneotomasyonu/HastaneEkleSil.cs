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
    public partial class HastaneEkleSil : Form
    {
        

        public HastaneEkleSil()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.adminekranı.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into hastane (hastaneAdi,ili,ilcesi,kapasitesi) Values(@hastaneadi,@ili,@ilçesi,@kapsitesi)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    
                    komut.Parameters.AddWithValue("@hastaneadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@ili", textBox3.Text);
                    komut.Parameters.AddWithValue("@ilçesi", textBox4.Text);
                    komut.Parameters.AddWithValue("@kapsitesi", textBox5.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni hastane başarı ile eklenmiştir.");
                    baglanti.Close();
                   
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    hastanegetir();
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            try
                {
                    baglanti.Open();
                    string silmesorgu = "DELETE from hastane where hastaneAdi=@hastaneıd";
                    SqlCommand silmekomut = new SqlCommand(silmesorgu, baglanti);
                    silmekomut.Parameters.AddWithValue("@hastaneıd", dataGridView1.CurrentRow.Cells[1].Value.ToString());

                    silmekomut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi başarıyla sonuçlanmıştır.");
                    baglanti.Close();
                    
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                hastanegetir();
                }
                catch (Exception )
                {

                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void hastanegetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from hastane", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void HastaneEkleSil_Load(object sender, EventArgs e)
        {
            hastanegetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if ( textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE hastane SET hastaneAdi=@hastaneadi,ili=@ili,ilcesi=@ilçesi,kapasitesi=@kapasitesi where hastaneID=@hid ";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@hid", textBox1.Text);
                    komut.Parameters.AddWithValue("@hastaneadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@ili", textBox3.Text);
                    komut.Parameters.AddWithValue("@ilçesi", textBox4.Text);
                    komut.Parameters.AddWithValue("@kapasitesi", textBox5.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("hastane başarı ile güncellenmiştir.");
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    hastanegetir();

                }
                catch (Exception w)
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
    }
}
