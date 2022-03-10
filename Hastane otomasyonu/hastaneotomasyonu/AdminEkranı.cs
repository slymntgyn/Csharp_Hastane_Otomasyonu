using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneoto
{
    public partial class AdminEkranı : Form
    {
        public AdminEkranı()
        {
            InitializeComponent();
        }

        private void AdminEkranı_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.admingirişpaneli.Show(); // formlar klasında tanımladığımız formAdminGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void doktorekle_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.doktorekle.Show();
            this.Hide();
        }

        private void KLİNİKEKLE_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.klinikeklesil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.hastaneklesil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hastane_oto.formlar.admineklesil.Show();
            this.Hide();
        }
    }
}
