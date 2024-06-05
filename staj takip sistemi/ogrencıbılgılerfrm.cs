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
    public partial class ogrencıbılgılerfrm : Form
    {
        public ogrencıbılgılerfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
                string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtTC.Text) ||
                string.IsNullOrEmpty(txtFakulte.Text) || string.IsNullOrEmpty(txtBolum.Text) ||
                string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into stajbasvuruÖğrenci(oğrenci_ad,oğrenci_soyad,oğrenci_no,tc,fakulte,bolum,harf_notu,staj_turu,kabul_gun,kabuldegıl_gun) values(@ograd,@ogrsoyad,@ogrno,@ogrtc,@ogrfak,@ogrbol,@ogrharf,@ogrstajtur,@ogrkabulgun,@ogrkabuldegılgun)", bgl.baglanti());
            komut.Parameters.AddWithValue("@ograd", txtAd.Text);
            komut.Parameters.AddWithValue("@ogrsoyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@ogrno", txtNo.Text);
            komut.Parameters.AddWithValue("@ogrtc", txtTC.Text);
            komut.Parameters.AddWithValue("@ogrfak", txtFakulte.Text);
            komut.Parameters.AddWithValue("@ogrbol", txtBolum.Text);
            komut.Parameters.AddWithValue("@ogrharf", textBox10.Text);
            komut.Parameters.AddWithValue("@ogrstajtur", textBox7.Text);
            komut.Parameters.AddWithValue("@ogrkabulgun", textBox8.Text);
            komut.Parameters.AddWithValue("@ogrkabuldegılgun", textBox9.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni öğrenci eklenmiştir");
            LoadData();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stajbasvuruÖğrenci", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void LoadData()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from stajbasvuruÖğrenci", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) ||
        string.IsNullOrEmpty(txtNo.Text) || string.IsNullOrEmpty(txtTC.Text) ||
        string.IsNullOrEmpty(txtFakulte.Text) || string.IsNullOrEmpty(txtBolum.Text) ||
        string.IsNullOrEmpty(textBox10.Text) || string.IsNullOrEmpty(textBox7.Text) ||
        string.IsNullOrEmpty(textBox8.Text) || string.IsNullOrEmpty(textBox9.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stajbasvuruÖğrenci WHERE oğrenci_no=@p1", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@p1", txtNo.Text);

            int rowCount = (int)checkCommand.ExecuteScalar(); // Sorguyu çalıştır ve etkilenen satır sayısını al

            // Eğer öğrenci numarası mevcut değilse
            if (rowCount == 0)
            {
                MessageBox.Show("Öğrenci numarası bulunamadı.");
                return; // Öğrenci numarası bulunamazsa işlemi sonlandır
            }

            DialogResult dialogResult = MessageBox.Show("Güncellemek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("update stajbasvuruÖğrenci set oğrenci_ad=@ograd, oğrenci_soyad=@ogrsoyad, oğrenci_no=@ogrno, tc=@ogrtc, fakulte=@ogrfak, bolum=@ogrbol, harf_notu=@ogrharf, staj_turu=@ogrstajtur, kabul_gun=@ogrkabulgun, kabuldegıl_gun=@ogrkabuldegılgun where oğrenci_no=@ogrno", bgl.baglanti());
                komut.Parameters.AddWithValue("@ograd", txtAd.Text);
                komut.Parameters.AddWithValue("@ogrsoyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@ogrno", txtNo.Text);
                komut.Parameters.AddWithValue("@ogrtc", txtTC.Text);
                komut.Parameters.AddWithValue("@ogrfak", txtFakulte.Text);
                komut.Parameters.AddWithValue("@ogrbol", txtBolum.Text);
                komut.Parameters.AddWithValue("@ogrharf", textBox10.Text);
                komut.Parameters.AddWithValue("@ogrstajtur", textBox7.Text);
                komut.Parameters.AddWithValue("@ogrkabulgun", textBox8.Text);
                komut.Parameters.AddWithValue("@ogrkabuldegılgun", textBox9.Text);
                komut.ExecuteNonQuery();

                MessageBox.Show("Öğrenci bilgileri güncellenmiştir");
                LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtAd.Text = row.Cells["oğrenci_ad"].Value.ToString();
                txtSoyad.Text = row.Cells["oğrenci_soyad"].Value.ToString();
                txtNo.Text = row.Cells["oğrenci_no"].Value.ToString();
                txtTC.Text = row.Cells["tc"].Value.ToString();
                txtFakulte.Text = row.Cells["fakulte"].Value.ToString();
                txtBolum.Text = row.Cells["bolum"].Value.ToString();
                textBox10.Text = row.Cells["harf_notu"].Value.ToString();
                textBox7.Text = row.Cells["staj_turu"].Value.ToString();
                textBox8.Text = row.Cells["kabul_gun"].Value.ToString();
                textBox9.Text = row.Cells["kabuldegıl_gun"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stajbasvuruÖğrenci WHERE oğrenci_no=@p1", bgl.baglanti());
            checkCommand.Parameters.AddWithValue("@p1", txtNo.Text);

            int rowCount = (int)checkCommand.ExecuteScalar(); // Sorguyu çalıştır ve etkilenen satır sayısını al

            // Eğer öğrenci numarası mevcut değilse
            if (rowCount == 0)
            {
                MessageBox.Show("Öğrenci numarası bulunamadı.");
            }
            else
            {
                // Silme işlemi için kullanıcıdan onay al
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlCommand deleteCommand = new SqlCommand("DELETE FROM stajbasvuruÖğrenci WHERE oğrenci_no=@p1", bgl.baglanti());
                    deleteCommand.Parameters.AddWithValue("@p1", txtNo.Text);
                    int affectedRows = deleteCommand.ExecuteNonQuery(); // Silme işlemini gerçekleştir ve etkilenen satır sayısını al
                    bgl.baglanti().Close();

                    // Silme işlemi başarılıysa
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Kullanıcı silinmiştir.");
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi gerçekleştirilemedi.");
                    }
                }
            }
        }

        private void btngeri4_Click(object sender, EventArgs e)
        {
            ogretmenfrm ogranasayfa = new ogretmenfrm();
            this.Hide();
            ogranasayfa.Show();
        }
    }
}
