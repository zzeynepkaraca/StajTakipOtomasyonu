using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staj_takip_sistemi
{
    public partial class ogretmenfrm : Form
    {
        public ogretmenfrm()
        {
            InitializeComponent();
        }

        private void btnStajdurum_Click(object sender, EventArgs e)
        {
            ogrencıbılgılerfrm stajDurum = new ogrencıbılgılerfrm();
            stajDurum.Show();
            this.Hide();
        }

        private void btnStajdefteriOgretmen_Click(object sender, EventArgs e)
        {
            stajdefterıogretmenfrm stajOnaylama = new stajdefterıogretmenfrm();
            stajOnaylama.Show();
            this.Hide();
        }

        private void btnStajyerogrenci_Click(object sender, EventArgs e)
        {
            toplukatyıteklemefrm topluOgrenci = new toplukatyıteklemefrm();
            topluOgrenci.Show();
            this.Hide();
        }

        private void btnDanısmanogrencı_Click(object sender, EventArgs e)
        {
            kurumeklemefrm kurumeklefrm = new kurumeklemefrm();
            kurumeklefrm.Show();
            this.Hide();

        }

        private void btncıkıs3_Click(object sender, EventArgs e)
        {
            gırısfrm giris = new gırısfrm();
            this.Close();
            giris.Show();
        }
    }
}
