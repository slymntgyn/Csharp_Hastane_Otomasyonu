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
    public partial class DoktorEkle : Form
    {
        public DoktorEkle()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DoktorEkle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from klinik", baglanti);
            da.Fill(dt);
            comboBox1.ValueMember = "klinikID";
            comboBox1.DisplayMember = "klinikAdi";
            comboBox1.DataSource = dt;
            baglanti.Close();
            doktorgetir();
            

        }
        void doktorgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from doktor", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
            if (textBox1.Text != "" )
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into doktor(doktorID, doktorAdiSoyadi, klinikID, kullanciAdi, sifre) Values(@did, @dAdiSoyadi, @dklinikid, @kadi, @sifre)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@did", textBox1.Text);
                    komut.Parameters.AddWithValue("@dAdiSoyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@dklinikid", comboBox1.SelectedValue);
                    komut.Parameters.AddWithValue("@kadi", textBox4.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox5.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Yeni doktor başarı ile eklenmiştir.");
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    doktorgetir();
                }
                catch (Exception )
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen kontrol edip tekrar deneyiniz.","Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
                baglanti.Close();
            }
            
           
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);

            try
                {
                    baglanti.Open();
                    string silmesorgu = "DELETE from doktor where doktorID=@doktorıd";
                    SqlCommand silmekomut = new SqlCommand(silmesorgu, baglanti);
                    silmekomut.Parameters.AddWithValue("@doktorıd", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    
                    silmekomut.ExecuteNonQuery();
                    MessageBox.Show("Silme İşlemi başarıyla sonuçlanmıştır.");
                    baglanti.Close();
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    doktorgetir();
                }
                catch (Exception)
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "UPDATE doktor Set doktorAdiSoyadi=@dAdiSoyadi,klinikID=@dklinikid,kullanciAdi=@kadi,sifre=@sifre where doktorID=@did";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@did", textBox1.Text);
                    komut.Parameters.AddWithValue("@dAdiSoyadi", textBox2.Text);
                    komut.Parameters.AddWithValue("@dklinikid", comboBox1.SelectedValue);
                    komut.Parameters.AddWithValue("@kadi", textBox4.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox5.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show(" doktor başarı ile Güncellenmiştir.");
                    
                    baglanti.Close();
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    doktorgetir();


                }
                catch (Exception )
                {

                    MessageBox.Show("Bir hata gerçekleşti lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş giriş yapılmaz");
                baglanti.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            /*ComboBox getirilecek*/
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox5.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox5.PasswordChar = '*';
            }
        }
    }
}
