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
    public partial class stajdurumu : Form
    {
        public stajdurumu()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void Form6_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select ögrenci_no,firma_adı,staj_başlangıç,staj_bitiş,staj_konusu,staj_puanı,durumu from stajdurumutable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void btnOgrencıAra_Click(object sender, EventArgs e)
        {
            string ogrenciArama = txtÖgrencinumarası.Text;

            SqlDataAdapter da = new SqlDataAdapter("select ögrenci_no,firma_adı,staj_başlangıç,staj_bitiş,staj_konusu,staj_puanı,durumu from stajdurumutable where ögrenci_no like @ögrenci_no", bgl.baglanti());

            da.SelectCommand.Parameters.AddWithValue("@ögrenci_no", "%" + ogrenciArama + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count) // Geçerli bir satır indeksi olduğundan emin olun
            {
                DataGridViewCell durumCell = dataGridView1.Rows[e.RowIndex].Cells["durumu"];

                // Durum hücresi null değilse ve değeri varsa renk ayarı yapın
                if (durumCell != null && durumCell.Value != null)
                {
                    string durum = durumCell.Value.ToString();

                    // Duruma bağlı olarak satır rengini ayarlayın
                    if (durum == "Onaylandı")
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (durum == "onaylanmadı")
                    {
                        dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
            }
        }

        private void btngeri6_Click(object sender, EventArgs e)
        {
            ogrencıfrm ogrencifrm = new ogrencıfrm();
            this.Hide();
            ogrencifrm.Show();
        }
    }
}
