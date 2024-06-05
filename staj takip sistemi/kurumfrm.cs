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

namespace staj_takip_sistemi
{
    public partial class kurumfrm : Form
    {
        public kurumfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void button1_Click(object sender, EventArgs e)
        {
            string adresArama = textBoxkurum.Text;

            SqlDataAdapter da = new SqlDataAdapter("select kurum_adı, kurum_telefon, kurum_adres from kurumlartable where kurum_adres like @adres", bgl.baglanti());

            da.SelectCommand.Parameters.AddWithValue("@adres", "%" + adresArama + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select kurum_adı, kurum_telefon, kurum_adres from kurumlartable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btngeri9_Click(object sender, EventArgs e)
        {
            ogrencıfrm ogrencifrm = new ogrencıfrm();
            this.Hide();
            ogrencifrm.Show();
        }
    }
}
