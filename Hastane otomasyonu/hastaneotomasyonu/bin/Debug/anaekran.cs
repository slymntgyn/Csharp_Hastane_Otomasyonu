using hastane_oto;
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
    public partial class Anaekran : Form
    {
        public Anaekran()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formlar.admingirişpaneli.Show(); // formlar klasında tanımladığımız formAdminGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formlar.doktorgirişekranı.Show(); // formlar klasında tanımladığımız formDoktorGirisPaneli formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formlar.hastagirişpaneli.Show();// formlar klasında tanımladığımız formGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void anaekran_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            formlar.admingirişpaneli.Show(); // formlar klasında tanımladığımız formAdminGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void label3_Click(object sender, EventArgs e)
        {
            formlar.doktorgirişekranı.Show(); // formlar klasında tanımladığımız formDoktorGirisPaneli formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void label4_Click(object sender, EventArgs e)
        {
            formlar.hastagirişpaneli.Show();// formlar klasında tanımladığımız formGiris formumuzu göstertiyoruz.
            this.Hide(); // Bu ana ekran formumuzu gizledik.
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult giriskapanis = MessageBox.Show("Programı kapatmak istediğinizden eminmisiniz ? ", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (giriskapanis == DialogResult.No)
            {
                
                return;

            }
            //Environment.Exit(0);
            Application.Exit();
        }
    }
}
