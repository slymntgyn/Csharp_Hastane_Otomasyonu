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
    public partial class AdminEkleSil : Form
    {
        

        public AdminEkleSil()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminEkleSil_Load(object sender, EventArgs e)
        {
            
            admingetir();
            
        }
        void admingetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Admin", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.adminekranı.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into admin ( adminID,kullaniciAdi,sifre) Values( @adminid, @kullaniciadi,@sifre)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@adminid", textBox1.Text);
                    komut.Parameters.AddWithValue("@kullaniciadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                    
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni admin başarı ile eklenmiştir.");
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    admingetir();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen tekrar deneyiniz.","Bir hata gerçekleşti",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            try
                {
                    baglanti.Open();
                    string silmesorgu = "DELETE from admin where adminID=@adminid";
                    SqlCommand silmekomut = new SqlCommand(silmesorgu, baglanti);
                    silmekomut.Parameters.AddWithValue("@adminid", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    silmekomut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi başarıyla sonuçlanmıştır.");
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    admingetir();
                }
                catch (Exception )
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE Admin Set kullaniciAdi=@kadi,sifre=@sifre where adminID=@did";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@did", textBox1.Text);
                    komut.Parameters.AddWithValue("@kadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox3.Text);
                   
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Admin başarı ile Güncellenmiştir.");
                    
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();

                    admingetir();


                }
                catch (Exception )
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
                baglanti.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox3.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
