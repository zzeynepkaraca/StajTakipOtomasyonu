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
    public partial class ogrencıstajdefterıfrm : Form
    {
        public ogrencıstajdefterıfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void btnBelgeYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents|*.docx";
            openFileDialog.Title = "Staj Defteri Dosyasını Seçin";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                label4.Text = filePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ogrenciNo = txtStajdefterıNo.Text;
            string danismanAdi = txtStajdefterıDanısman.Text;
            string defterYolu = label4.Text;

            if (string.IsNullOrEmpty(ogrenciNo) || string.IsNullOrEmpty(danismanAdi) || string.IsNullOrEmpty(defterYolu))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (ogrenciNo.Length > 11)
            {
                MessageBox.Show("Öğrenci numarası en fazla 11 karakter olmalıdır.");
                return;
            }

            try
            {
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM stajdurumutable WHERE ögrenci_no=@ogrno", bgl.baglanti());
                checkCommand.Parameters.AddWithValue("@ogrno", ogrenciNo);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    SqlCommand updateCommand = new SqlCommand("UPDATE stajdurumutable SET defter_yol=@defter, staj_danisman=@danisman WHERE ögrenci_no=@ogrno", bgl.baglanti());
                    updateCommand.Parameters.AddWithValue("@defter", defterYolu);
                    updateCommand.Parameters.AddWithValue("@danisman", danismanAdi);
                    updateCommand.Parameters.AddWithValue("@ogrno", ogrenciNo);

                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla güncellendi.");
                        txtStajdefterıNo.Clear();
                        txtStajdefterıDanısman.Clear();
                        label4.Text = "Dosya Yolu Seçiniz:";

                        txtStajdefterıNo.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt güncellenemedi.");
                    }
                }
                else
                {
                    MessageBox.Show("Öğrenci numarası bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btngeri5_Click(object sender, EventArgs e)
        {
            ogrencıfrm ogrencifrm = new ogrencıfrm();
            this.Hide();
            ogrencifrm.Show();
        }
    }
}

