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

namespace ElifUygunHastane
{
    public partial class AdminRandevuShow : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public AdminRandevuShow()
        {
            InitializeComponent();
        }

        private void AdminRandevuShow_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'elifUygunHastaneDataSet1.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.elifUygunHastaneDataSet1.Randevular);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string tc = maskedTextBox1.Text;

            // TC kimlik numarasının doğruluğu kontrolü
            if (tc.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Randevular WHERE hastatc = @hastatc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@hastatc", tc);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Randevu silme işlemi başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC kimlik numarasına sahip randevu bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tc = maskedTextBox1.Text;
            string hastaAdi = textBox1.Text;
            string hastaSoyadi = textBox2.Text;
            DateTime yeniRandevuTarihi = dateTimePicker1.Value;

            // TC kimlik numarasının doğruluğu kontrolü
            if (tc.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                return;
            }

            // Geçmiş tarihe randevu verilememesi kontrolü
            if (yeniRandevuTarihi.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Geçmiş bir tarihe randevu verilemez.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Randevular SET hastaadi = @hastaadi, hastasoyadi = @hastasoyadi, randevutarih = @randevutarih WHERE hastatc = @hastatc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@hastaadi", hastaAdi);
                    command.Parameters.AddWithValue("@hastasoyadi", hastaSoyadi);
                    command.Parameters.AddWithValue("@randevutarih", yeniRandevuTarihi);
                    command.Parameters.AddWithValue("@hastatc", tc);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Randevu güncelleme işlemi başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC kimlik numarasına sahip randevu bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
