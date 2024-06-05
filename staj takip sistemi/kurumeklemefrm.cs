using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace staj_takip_sistemi
{
    public partial class kurumeklemefrm : Form
    {
        public kurumeklemefrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre;
        private void Form12_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from kurumlartable", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Adreslerin sadece bir kere eklenmesini sağlamak için bir HashSet kullanabiliriz.
            HashSet<string> uniqueAddresses = new HashSet<string>();

            // DataTable'daki her satırı döngüyle gezerek adresleri combobox'a ekleyeceğiz.
            foreach (DataRow row in dt.Rows)
            {
                string address = row["kurum_adres"].ToString();

                // Eğer adres daha önce eklenmediyse combobox'a ekleyelim.
                if (!uniqueAddresses.Contains(address))
                {
                    comboBox1.Items.Add(address);
                    uniqueAddresses.Add(address);
                }
            }

            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) ||
               string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            SqlCommand komut = new SqlCommand("insert into kurumlartable(kurum_kodu,kurum_adı,kurum_telefon,kurum_adres) values(@kod,@ad,@tel,@adres)", bgl.baglanti());
            komut.Parameters.AddWithValue("@kod", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@tel", textBox3.Text);
            komut.Parameters.AddWithValue("@adres", textBox4.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kurum eklemesi yapılmıştır");


            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedAddress = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedAddress))
            {
                MessageBox.Show("Lütfen bir adres seçin.");
                return;
            }

            // Seçilen adres ile ilgili sorguyu hazırla
            string query = "SELECT * FROM kurumlartable WHERE kurum_adres = @address";

            SqlCommand command = new SqlCommand(query, bgl.baglanti());
            {
                command.Parameters.AddWithValue("@address", selectedAddress);

                // Sorguyu çalıştır ve sonuçları al
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Sonuçları DataGridView'e yükle
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogretmenfrm ogranasayfa = new ogretmenfrm();
            this.Hide();
            ogranasayfa.Show();
        }
    }
}
