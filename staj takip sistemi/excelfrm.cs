using ExcelDataReader;
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
using System.Windows.Forms.Design.Behavior;

namespace staj_takip_sistemi
{
    public partial class excelfrm : Form
    {
        public excelfrm()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public static string kulid, kulad, kulsifre, kulyetki;
        DataTableCollection dtc;
        private void button1_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                openFileDialog.Title = "Excel Dosyası Seçin";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    labelKonum.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader excelReader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (x) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });

                            // İlk tabloyu DataGridView'e ekle
                            if (result.Tables.Count > 0)
                            {
                                dataGridView1.DataSource = result.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("Excel dosyasında hiçbir tablo bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                // Kullanıcıdan onay al
                DialogResult dialogResult = MessageBox.Show("Excell tablosundan toplu kayıt eklemek üzeresiniz. Emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Tüm satırlar üzerinde döngü yaparak verileri ekleme
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Yeni satırı atla

                        try
                        {
                            SqlCommand command = new SqlCommand("INSERT INTO stajyerögrencitable (Id, öğrenci_no, ad, soyad, üniversite, bölüm, departman, kurum_ad, kurum_tel, kurum_posta) VALUES (@Id, @ogrNo, @ad, @soyad, @universite, @bolum, @departman, @kurumAd, @kurumTel, @kurumPosta)", bgl.baglanti());
                            {
                                command.Parameters.AddWithValue("@Id", row.Cells["Id"].Value);
                                command.Parameters.AddWithValue("@ogrNo", row.Cells["öğrenci_no"].Value);
                                command.Parameters.AddWithValue("@ad", row.Cells["ad"].Value);
                                command.Parameters.AddWithValue("@soyad", row.Cells["soyad"].Value);
                                command.Parameters.AddWithValue("@universite", row.Cells["üniversite"].Value);
                                command.Parameters.AddWithValue("@bolum", row.Cells["bölüm"].Value);
                                command.Parameters.AddWithValue("@departman", row.Cells["departman"].Value);
                                command.Parameters.AddWithValue("@kurumAd", row.Cells["kurum_ad"].Value);
                                command.Parameters.AddWithValue("@kurumTel", row.Cells["kurum_tel"].Value);
                                command.Parameters.AddWithValue("@kurumPosta", row.Cells["kurum_posta"].Value);

                                command.ExecuteNonQuery();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata: " + ex.Message);
                        }
                    }
                    MessageBox.Show("Kayıtlar başarıyla eklendi.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen eklemek için bir kayıt seçin.");
            }
        }

        private void btngeri10_Click(object sender, EventArgs e)
        {
            toplukatyıteklemefrm toplu = new toplukatyıteklemefrm();
            toplu.Show();
            this.Hide();
        }
    }
}