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
    public partial class AdminHastaAdd : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public AdminHastaAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hastaadi = textBox1.Text;
            string hastasoyadi = textBox2.Text;
            string hastatc = maskedTextBox1.Text;
            DateTime randevutarih = dateTimePicker1.Value.Date;

            // Bugün ve geçmiş tarihe randevu seçilemez kontrolü
            if (randevutarih <= DateTime.Today)
            {
                MessageBox.Show("Geçmiş Tarihe Randevu Alınamaz.");
                return;
            }

            // TC kimlik numarasının doğruluğu kontrolü
            if (hastatc.Length != 11)
            {
                MessageBox.Show("TC kimlik numarası 11 haneli olmalıdır.");
                return;
            }

            if (string.IsNullOrEmpty(hastaadi) || string.IsNullOrEmpty(hastasoyadi) || string.IsNullOrEmpty(hastatc))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Randevular (hastaadi, hastasoyadi, hastatc, randevutarih) VALUES (@hastaadi, @hastasoyadi, @hastatc, @randevutarih)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@hastaadi", hastaadi);
                    command.Parameters.AddWithValue("@hastasoyadi", hastasoyadi);
                    command.Parameters.AddWithValue("@hastatc", hastatc);
                    command.Parameters.AddWithValue("@randevutarih", randevutarih);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Randevu ekleme başarılı.");
                        // Eğer isteniyorsa, eklendikten sonra bir işlem yapılabilir.
                    }
                    else
                    {
                        MessageBox.Show("Randevu ekleme başarısız.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }
    }
}
