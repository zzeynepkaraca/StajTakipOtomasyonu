using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_takip_sistemi
{
    public partial class toplukatyıteklemefrm : Form
    {
        public toplukatyıteklemefrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void button1_Click(object sender, EventArgs e)
        {
            excelfrm topluKayit = new excelfrm();
            topluKayit.Show();
            this.Hide();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stajyerögrencitable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btngeri11_Click(object sender, EventArgs e)
        {
            ogretmenfrm ogranasayfa = new ogretmenfrm();
            this.Hide();
            ogranasayfa.Show();
        }
    }
}
