using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace staj_takip_sistemi
{
    public partial class ogrencıfrm : Form
    {
        public ogrencıfrm()
        {
            InitializeComponent();
        }

        private void btnStajbasvuru_Click(object sender, EventArgs e)
        {
            stajbasvurufrm stajBasvuru = new stajbasvurufrm();
            stajBasvuru.Show();
            this.Hide();
        }

        private void btnStajdurum_Click(object sender, EventArgs e)
        {
            stajdurumu stajDurum = new stajdurumu();
            stajDurum.Show();
            this.Hide();
        }

        private void btnStajdefteriOgrenci_Click(object sender, EventArgs e)
        {
            ogrencıstajdefterıfrm stajDefter = new ogrencıstajdefterıfrm();
            stajDefter.Show();
            this.Hide();
        }

        private void btnKurumlar_Click(object sender, EventArgs e)
        {
            kurumfrm kurum = new kurumfrm();
            kurum.Show();
            this.Hide();
        }

        private void btncıkıs2_Click(object sender, EventArgs e)
        {
            gırısfrm giris = new gırısfrm();
            this.Close();
            giris.Show();
        }
    }
}
