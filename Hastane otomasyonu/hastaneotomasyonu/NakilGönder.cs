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
    public partial class NakilGönder : Form
    {
        

        public NakilGönder()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorekran.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.SelectedItem != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into nakiller ( nakilID,hastaTC,nakilEdilenHastane) Values( @nakilID, @hastatc,@nakiledlnhstn)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@nakilID", textBox1.Text);
                    komut.Parameters.AddWithValue("@hastatc", textBox2.Text);
                    komut.Parameters.AddWithValue("@nakiledlnhstn", comboBox1.SelectedValue);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Nakil gönderilmiştir.");

                    baglanti.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    
                    hastagetir();

                }
                catch (Exception)
                {

                    MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Lüttfen Boş giriş yapmayınız !", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void hastagetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from hasta", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void NakilGönder_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from hastane", baglanti);
            da1.Fill(dt1);
            comboBox1.ValueMember = "hastaneID";
            comboBox1.DisplayMember = "hastaneAdi";
            comboBox1.DataSource = dt1;
            baglanti.Close();
            hastagetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
