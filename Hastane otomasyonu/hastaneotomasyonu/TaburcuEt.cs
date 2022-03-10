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
    public partial class TaburcuEt : Form
    {
        sqlbaglanti bgl = new sqlbaglanti();
        void yatisgetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from yatis", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        public TaburcuEt()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorekran.Show();
            this.Hide();
        }
        public static string tckimlik = "";
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "")
            {
                tckimlik = textBox1.Text.ToString();
                if (tckimlik.Length == 11)
                {
                    char[] rakamlar = tckimlik.ToCharArray();
                    int kural1 = 0, hane11 = rakamlar[10], hane10 = rakamlar[9];
                    //kural1: ilk 10 rakamın toplamının birler basamağı, 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i++)
                    {
                        kural1 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural1 = kural1.ToString().ToCharArray();

                    int kural2tek = 0, kural2cift = 0;
                    //kural2:  1, 3, 5, 7 ve 9. rakamın toplamının 7 katı ile 2, 4, 6 ve 8. rakamın toplamının 9 katının toplamının birler basamağı 10. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural2tek += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    for (int i = 1; i < 9; i += 2)
                    {
                        kural2cift += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural2 = ((7 * kural2tek) + (9 * kural2cift)).ToString().ToCharArray();

                    int kural3 = 0;
                    //1, 3, 5, 7 ve 9. rakamın toplamının 8 katının birler basamağı 11. rakamı vermektedir.
                    for (int i = 0; i < 10; i += 2)
                    {
                        kural3 += Convert.ToInt32(rakamlar[i].ToString());
                    }
                    char[] birlerbasamagikural3 = (8 * kural3).ToString().ToCharArray();

                    if ((birlerbasamagikural1[birlerbasamagikural1.Length - 1] == hane11) && (birlerbasamagikural2[birlerbasamagikural2.Length - 1] == hane10) && (birlerbasamagikural3[birlerbasamagikural3.Length - 1] == hane11) && tckimlik != "00000000000")
                    {

                        try
                        {
                            baglanti.Open();
                            string silmesorgu = "DELETE from yatis where hastaID=@hastaıd";
                            SqlCommand silmekomut = new SqlCommand(silmesorgu, baglanti);
                            silmekomut.Parameters.AddWithValue("@hastaıd", textBox1.Text.ToString());
                            silmekomut.ExecuteNonQuery();
                            MessageBox.Show("Hasta Taburcu edilmiştir");
                            baglanti.Close();
                            yatisgetir();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            baglanti.Close();
                            yatisgetir();
                        }
                    }

                    else
                    {

                        MessageBox.Show("TC Kimlik Numarası Geçerli Değildir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show(" TC Kimlik Numaranızı Eksik Girdiniz Lütfen Kontrol Ediniz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {

                MessageBox.Show(" TC Kimlik Numarası Giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
                yatisgetir();

            }
           
            }
            /*else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız !", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                yatisgetir();
            }*/
        
        

        private void TaburcuEt_Load(object sender, EventArgs e)
        {
          
            yatisgetir();
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
