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
    public partial class ÜyeOl : Form
    {
        

        public ÜyeOl()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.hastagirişpaneli.Show(); // anaekran formumuzu gösterip
            this.Hide(); // şuan bulunan admin giriş formumuzu gizliyoruz.
        }
        public static string tckimlik = "";
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox1.Text != "")
            {
                tckimlik = textBox1.Text.ToString();
                if (tckimlik != "")
                {
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

                                string sorgu = "Insert into hasta(TC,Adi,soyadi,parola,anneAdi,babaAdi,dogumTarihi,dogumYeri,cinsiyeti,cepTel,ePosta) Values(@tc, @adi, @soyadi, @parola, @anneadi,@babaadi,@dtarihi,@dyeri,@cinsiyeti,@ceptel,@eposta)";
                                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                                komut.Parameters.AddWithValue("@tc", textBox1.Text);
                                komut.Parameters.AddWithValue("@adi", textBox2.Text);
                                komut.Parameters.AddWithValue("@soyadi", textBox3.Text);
                                komut.Parameters.AddWithValue("@parola", textBox10.Text);
                                komut.Parameters.AddWithValue("@anneadi", textBox7.Text);
                                komut.Parameters.AddWithValue("@babaadi", textBox6.Text);
                                komut.Parameters.AddWithValue("@dtarihi", dateTimePicker1.Value);
                                komut.Parameters.AddWithValue("@dyeri", textBox11.Text);
                                komut.Parameters.AddWithValue("@cinsiyeti", comboBox1.SelectedItem);
                                komut.Parameters.AddWithValue("@ceptel", textBox8.Text);
                                komut.Parameters.AddWithValue("@eposta", textBox9.Text);
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Başarıyla üye olunmuştur.");
                                baglanti.Close();
                                textBox1.Clear();
                                textBox2.Clear();
                                textBox3.Clear();
                                textBox6.Clear();
                                textBox7.Clear();
                                textBox8.Clear();
                                textBox9.Clear();
                                textBox10.Clear();
                                textBox11.Clear();
                            }
                            catch (Exception)
                            {

                                MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                baglanti.Close();
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
                    
                } 
            }
            else
            {
                MessageBox.Show("Lütfen boş giriş yapmayınız !", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /*Tc kimlik aynı olursa Mesaj verdir
         Parolayı gösterme*/
        private void ÜyeOl_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox10.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox10.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
