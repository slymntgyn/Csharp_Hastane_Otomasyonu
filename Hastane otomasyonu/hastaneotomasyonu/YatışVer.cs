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
    public partial class YatışVer : Form
    {
        

        public YatışVer()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorekran.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    baglanti.Open();
                    string sorgu = "Insert into yatis ( yatisID,hastaID) Values(@yatisıd,@hastatc)";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@yatisıd", textBox2.Text);
                    komut.Parameters.AddWithValue("@hastatc", textBox1.Text);
                    

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hastaya yatis verilmiştir.");
                    baglanti.Close();
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
                MessageBox.Show("Boş giriş yapılmaz");
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

        private void YatışVer_Load(object sender, EventArgs e)
        {
            hastagetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
