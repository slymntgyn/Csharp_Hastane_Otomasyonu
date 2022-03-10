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
    public partial class HastaGirişPaneli : Form
    {
        public HastaGirişPaneli()
        {
            InitializeComponent();
            
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void HastaneGirişGeri_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.formAnaEkran.Show(); // anaekran formumuzu gösterip
            this.Hide(); // şuan bulunan admin giriş formumuzu gizliyoruz.
        }

        private void HastaneGirişÜyeOl_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            hastane_oto.formlar.üyeol.Show(); // anaekran formumuzu gösterip
            this.Hide(); // şuan bulunan admin giriş formumuzu gizliyoruz.
        }
        public static string tckimlik;
        private void HastaneGirişGiriş_Click(object sender, EventArgs e)
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
                                string sql = "select * from hasta where TC=@kadi and parola=@sifre";
                                SqlParameter prm1 = new SqlParameter("@kadi", textBox1.Text);
                                SqlParameter prm2 = new SqlParameter("@sifre", textBox2.Text);
                                SqlCommand komut = new SqlCommand(sql, baglanti);
                                komut.Parameters.Add(prm1);
                                komut.Parameters.Add(prm2);

                                DataTable dt = new DataTable();
                                SqlDataAdapter da = new SqlDataAdapter(komut);
                                da.Fill(dt);


                                if (dt.Rows.Count > 0)
                                {
                                    RandevuAl ra = new RandevuAl();
                                    ra.Show();
                                    textBox1.Clear();
                                    textBox2.Clear();
                                    this.Hide(); // bu formu gizledik
                                    baglanti.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    baglanti.Close();
                                }

                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Şifre hatalı lütfen tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                baglanti.Close();
                            }
                        }

                        else
                        {

                            MessageBox.Show("TC Kimlik Numarası Geçerli Değildir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        
                        
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

        private void HastaGirişPaneli_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //checkBox işaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                textBox2.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
