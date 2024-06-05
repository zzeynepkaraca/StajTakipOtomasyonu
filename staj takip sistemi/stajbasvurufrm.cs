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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace staj_takip_sistemi
{
    public partial class stajbasvurufrm : Form
    {
        public stajbasvurufrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;


        private void btnBasvuru_Click(object sender, EventArgs e)
        {
            if (txtbasvuruNo.Text.Length > 11)
            {
                MessageBox.Show("Öğrenci numarası en fazla 11 karakter olmalıdır.");
                return;
            }
            if (string.IsNullOrEmpty(txtbasvuruNo.Text) || string.IsNullOrEmpty(txtFırma.Text) ||
               string.IsNullOrEmpty(maskedTextBox1.Text) || string.IsNullOrEmpty(maskedTextBox2.Text) ||
            string.IsNullOrEmpty(txtBırım.Text) || string.IsNullOrEmpty(txtKonu.Text) ||
            string.IsNullOrEmpty(txtBasvuruDanısman.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into stajbasvuru(ogrenci_numarasi,firma_adi,baslangic_tarihi,bitis_tarihi,yapilacak_birim,staj_konusu,staj_danismani) values(@ogrno,@firmaad,@bastarih,@bittarih,@yapilacakbirim,@stajkonu,@stajdanisman)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ogrno", txtbasvuruNo.Text);
            komut.Parameters.AddWithValue("@firmaad", txtFırma.Text);
            komut.Parameters.AddWithValue("@bastarih", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@bittarih", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@yapilacakbirim", txtBırım.Text);
            komut.Parameters.AddWithValue("@stajkonu", txtKonu.Text);
            komut.Parameters.AddWithValue("@stajdanisman", txtBasvuruDanısman.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("staj başvurunuz yapılmıştır");


            txtbasvuruNo.Clear();
            txtFırma.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();
            txtBırım.Clear();
            txtKonu.Clear();
            txtBasvuruDanısman.Clear();
            txtbasvuruNo.Focus();

        }

        private void btngeri7_Click(object sender, EventArgs e)
        {
            ogrencıfrm ogrencifrm = new ogrencıfrm();
            this.Hide();
            ogrencifrm.Show();
        }
    }
}
