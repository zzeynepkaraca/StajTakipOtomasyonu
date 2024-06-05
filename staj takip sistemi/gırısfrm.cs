using System.Data.SqlClient;

namespace staj_takip_sistemi

{
    public partial class gýrýsfrm : Form
    {
        public gýrýsfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        bool durumkontrol = false;

        private void btnGirisÖgrenci_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from ögrencigiristable", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kullanýcý_adý"].ToString() == txtKullanýcýAdÖgrenci.Text && oku["sifre"].ToString() == txtÖgrenciSifre.Text)
                {
                    durumkontrol = true;
                    kulid = oku.GetValue(0).ToString();
                    kulad = oku.GetValue(1).ToString();
                    kulsifre = oku.GetValue(2).ToString();
                    ogrencýfrm frm2 = new ogrencýfrm();
                    frm2.Show();
                    this.Hide();
                    break;
                }
            }
            if (txtKullanýcýAdÖgrenci.Text == "" || txtÖgrenciSifre.Text == "")
            {
                MessageBox.Show("Öðrenci Kullanýcý adý veya þifre boþ olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ");
            }

        }




        private void btnGirisÖgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from ögretmengýrýstable", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["kullanýcý_ad"].ToString() == txtKullanýcýAdögretmen.Text && oku2["sifre"].ToString() == txtÖgretmenSifre.Text)
                {
                    durumkontrol = true;
                    kulid = oku2.GetValue(0).ToString();
                    kulad = oku2.GetValue(1).ToString();
                    kulsifre = oku2.GetValue(2).ToString();
                    ogretmenfrm frm3 = new ogretmenfrm();
                    frm3.Show();
                    this.Hide();
                    break;
                }
            }
            if (txtKullanýcýAdögretmen.Text == "" || txtÖgretmenSifre.Text == "")
            {
                MessageBox.Show("Öðretmen Kullanýcý adý veya þifre boþ olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ");
            }
            bgl.baglanti().Close();

        }

        private void btncýkýs3_Click(object sender, EventArgs e)
        {
            gýrýsfrm giris = new gýrýsfrm();
            this.Close();
            giris.Show();
        }
    }
}

