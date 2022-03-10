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
    public partial class Tahlilİste : Form
    {
        

        public Tahlilİste()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
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

       
        private void Tahlilİste_Load(object sender, EventArgs e)
        {
            randevugetir();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorekran.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            try
            {
                baglanti.Open();
                string sorgu = "Insert into tahlil (tahlilID,hastaTC,tahlilAdi) Values( @tahlilid, @hastatc,@tahliladi)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@tahlilid", textBox1.Text);
                komut.Parameters.AddWithValue("@hastatc", textBox2.Text);
                komut.Parameters.AddWithValue("@tahliladi",comboBox1.SelectedItem);

                komut.ExecuteNonQuery();
                MessageBox.Show(comboBox1.SelectedItem + " istenmiştir");
                baglanti.Close();
                textBox1.Clear();
                textBox2.Clear();
                
                randevugetir();
            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            randevugetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hastane_oto.formlar.röntgen.Show();
            this.Hide();
        }
    }
}
