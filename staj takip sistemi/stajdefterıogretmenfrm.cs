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
    public partial class stajdefterıogretmenfrm : Form
    {
        public stajdefterıogretmenfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void Form8_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from stajdurumutable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void LoadData()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from stajdurumutable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string ogrenciNo = selectedRow.Cells["ögrenci_no"].Value.ToString();

                DialogResult result = MessageBox.Show("Stajı onaylamak üzeresiniz. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {

                        SqlCommand command = new SqlCommand("UPDATE stajdurumutable SET durumu = 'Onaylandı' WHERE ögrenci_no = @ogrno", bgl.baglanti());
                        command.Parameters.AddWithValue("@ogrno", ogrenciNo);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Staj başarıyla onaylandı.");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }

                    // Veriyi yenile
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Lütfen onaylamak için bir staj seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string filePath = selectedRow.Cells["defter_yol"].Value.ToString();

                if (!string.IsNullOrEmpty(filePath))
                {
                    try
                    {
                        MessageBox.Show((filePath));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya açılamadı: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Dosya yolu bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir dosya seçin.");
            }
        }

        private void btngeri8_Click(object sender, EventArgs e)
        {
            ogretmenfrm ogranasayfa = new ogretmenfrm();
            this.Hide();
            ogranasayfa.Show();
        }
    }
}
