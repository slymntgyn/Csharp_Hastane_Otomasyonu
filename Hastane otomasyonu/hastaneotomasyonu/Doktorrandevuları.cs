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
    public partial class Doktorrandevuları : Form
    {
        

        public Doktorrandevuları()
        {
            InitializeComponent();
        }
        sqlbaglanti bgl = new sqlbaglanti();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.tahliliste.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.yatisver.Show();
            this.Hide();
        }

        private void DoktorRandevuGeri_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorgirişekranı.Show(); // formlar klasında tanımladığımız formDoktorGirisPaneli formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.nakilgönder.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.taburcuet.Show();
            this.Hide();
        }
        public void randevugetir()
        {
            SqlConnection baglanti = new SqlConnection(bgl.adres);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from randevu", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void Doktorrandevuları_Load(object sender, EventArgs e)
        {
            randevugetir();
        }
    }
}
