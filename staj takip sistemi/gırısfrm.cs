using System.Data.SqlClient;

namespace staj_takip_sistemi

{
    public partial class g�r�sfrm : Form
    {
        public g�r�sfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        bool durumkontrol = false;

        private void btnGiris�grenci_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from �grencigiristable", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["kullan�c�_ad�"].ToString() == txtKullan�c�Ad�grenci.Text && oku["sifre"].ToString() == txt�grenciSifre.Text)
                {
                    durumkontrol = true;
                    kulid = oku.GetValue(0).ToString();
                    kulad = oku.GetValue(1).ToString();
                    kulsifre = oku.GetValue(2).ToString();
                    ogrenc�frm frm2 = new ogrenc�frm();
                    frm2.Show();
                    this.Hide();
                    break;
                }
            }
            if (txtKullan�c�Ad�grenci.Text == "" || txt�grenciSifre.Text == "")
            {
                MessageBox.Show("��renci Kullan�c� ad� veya �ifre bo� olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre yanl��");
            }

        }




        private void btnGiris�gretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("select * from �gretmeng�r�stable", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                if (oku2["kullan�c�_ad"].ToString() == txtKullan�c�Ad�gretmen.Text && oku2["sifre"].ToString() == txt�gretmenSifre.Text)
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
            if (txtKullan�c�Ad�gretmen.Text == "" || txt�gretmenSifre.Text == "")
            {
                MessageBox.Show("��retmen Kullan�c� ad� veya �ifre bo� olamaz");
            }
            else if (durumkontrol == false)
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre yanl��");
            }
            bgl.baglanti().Close();

        }

        private void btnc�k�s3_Click(object sender, EventArgs e)
        {
            g�r�sfrm giris = new g�r�sfrm();
            this.Close();
            giris.Show();
        }
    }
}

