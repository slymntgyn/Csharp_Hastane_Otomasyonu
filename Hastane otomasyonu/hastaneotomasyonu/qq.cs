using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace hastaneoto
{

    class qq
    {
        public static SqlConnectionStringBuilder csb;
        public static SqlDataAdapter da;
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=SÜLEYMAN\SQLEXPRESS; Initial Catalog=Hastane Otomasyonu; Integrated Security=true;");

        public static SqlCommand komut;
        public static DataTable dt;
        public static SqlDataReader dr;

        public static void combo(SqlCommand cmd, string id, string ad, ComboBox cb)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr[id] = 0;
            dr[ad] = "";
            dt.Rows.InsertAt(dr, 0);
            cb.DataSource = dt;
            cb.DisplayMember = ad;
            cb.ValueMember = id;
            baglanti.Close();
        }

        public static void veri_getir(SqlCommand cmd)
        {
            if (baglanti.State == ConnectionState.Open)
                baglanti.Close();
            baglanti.Open();
            komut = cmd;
            dr = komut.ExecuteReader();
            baglanti.Close();
        }
    }
}
