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
using System.Configuration;
namespace hastaneoto
{
    public partial class RandevuAl : Form
    { 
        

        public RandevuAl()
        {
            InitializeComponent();
            textBox1.Enabled = false;
        }
        sqlbaglanti bgl = new sqlbaglanti();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           hastane_oto.formlar.hastagirişpaneli.Show();// formlar klasında tanımladığımız formGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.riptal.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public static string tckimlik;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            if (textBox5.Text != "")
            {
                tckimlik = textBox5.Text.ToString();
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
                            string sorgu = "Insert into randevu(doktorID, klinikID,TC,tarih,saat,tarihVeSaat) Values(@rdıd, @rkıd, @tc, @tarih,@saat,@tarihVeSaat)";
                            SqlCommand komut = new SqlCommand(sorgu, baglanti);

                            komut.Parameters.AddWithValue("@rdıd", comboBox3.SelectedValue);
                            komut.Parameters.AddWithValue("@rkıd", comboBox2.SelectedValue);
                            komut.Parameters.AddWithValue("@tc", textBox5.Text);
                            komut.Parameters.AddWithValue("@tarih", dateTimePicker1.Value);

                            komut.Parameters.AddWithValue("@saat", comboBox1.SelectedItem.ToString());
                            try
                            {
                                komut.Parameters.AddWithValue("@tarihVeSaat", dateTimePicker1.Value.ToShortDateString() + "-" + comboBox1.SelectedItem.ToString() + " Doktoru: " + comboBox3.SelectedValue);
                                komut.ExecuteNonQuery();
                                MessageBox.Show("Randevu Alınmıştır.");
                                baglanti.Close();

                                textBox5.Clear();
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Bu doktora ait randevulardan bu tarih doludur. lütfen başka br tarih seçiniz!!!", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }




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
                baglanti.Close();
                

            }
            
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void RandevuAl_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            /* ComboBoxları*/
            baglanti.Open();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter("select * from klinik",baglanti);
             da.Fill(dt);
             comboBox2.ValueMember = "klinikID";
             comboBox2.DisplayMember = "klinikAdi";
             comboBox2.DataSource = dt;

             baglanti.Close();
            
            /*comboBox2.Enabled = false;*/
            /*
            baglanti.Open();
            DataTable dt1 = new DataTable();
            //select dr.doktorID,ki.klinikID from doktor dr Inner join klinik ki on dr.klinikID=ki.klinikID
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT klinik.klinikID,doktor.doktorID,doktor.doktorAdiSoyadi FROM doktor INNER JOIN klinik ON doktor.doktor_klinikID=klinik.klinikID WHERE doktor.doktor_klinikID=@kid", baglanti);
            Parameters.AddWithValue("@kid", comboBox3.SelectedValue.ToString());
            da1.Fill(dt1);
            
            comboBox3.ValueMember = "doktorID";
            comboBox3.DisplayMember = "doktorAdiSoyadi";
            comboBox3.DataSource = dt1;
            baglanti.Close();
            */
        }

        private void sekiz_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            try
            {
                if (comboBox1.SelectedIndex != 0)
                {
                    SqlCommand doktor = new SqlCommand("SELECT klinik.klinikID,doktor.doktorID,doktor.doktorAdiSoyadi FROM doktor INNER JOIN klinik ON doktor.klinikID=klinik.klinikID WHERE doktor.klinikID=@kid", baglanti);
                    doktor.Parameters.AddWithValue("@kid", comboBox2.SelectedValue.ToString());
                    qq.combo(doktor, "doktorID", "doktorAdiSoyadi", comboBox3);
                }
            }
            catch
            {
                MessageBox.Show("Hatalı bir işlem gerçekleştirildi lütfen kontrol edip tekrar deneyiniz.", "Bir hata gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
