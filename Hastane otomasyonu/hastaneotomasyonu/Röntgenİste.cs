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
    public partial class Röntgenİste : Form
    {
        

        public Röntgenİste()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void randevugetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from randevu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Röntgenİste_Load(object sender, EventArgs e)
        {
            randevugetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.tahliliste.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into röntgen ( röntgenID,hastaTC,bölgeninAdi,kacacidancekilecek) Values( @röntgenid, @hastatc,@bölgeadi,@aci)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@röntgenid", textBox1.Text);
                    komut.Parameters.AddWithValue("@hastatc", textBox2.Text);
                    komut.Parameters.AddWithValue("@bölgeadi", textBox3.Text);
                    komut.Parameters.AddWithValue("@aci", textBox4.Text);
                    
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Röntgen tahlili istenmiştir");
                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    randevugetir();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş giriş yapmayınız !", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
