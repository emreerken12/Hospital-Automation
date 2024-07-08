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
    public partial class AdminRandevuDoktor : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public AdminRandevuDoktor()
        {
            InitializeComponent();
        }








        private void button1_Click(object sender, EventArgs e)
        {
            string hastaTc = maskedTextBox1.Text;
            int doktorId;

            // TC kimlik numarasının doğruluğu kontrolü
            if (hastaTc.Length != 11)
            {
                MessageBox.Show("Hasta TC kimlik numarası 11 haneli olmalıdır.");
                return;
            }

            // Doktor ID'sinin doğruluğu kontrolü
            if (!int.TryParse(textBox1.Text, out doktorId))
            {
                MessageBox.Show("Geçerli bir doktor ID'si girilmelidir.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Randevular SET DoktorId = @doktorId WHERE hastatc = @hastaTc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@doktorId", doktorId);
                    command.Parameters.AddWithValue("@hastaTc", hastaTc);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doktor atama işlemi başarılı.");
                        // Eğer isteniyorsa, atandıktan sonra bir işlem yapılabilir.
                    }
                    else
                    {
                        MessageBox.Show("Belirtilen TC kimlik numarasına sahip hasta bulunamadı.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void AdminRandevuDoktor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'elifUygunHastaneDataSet3.Doktorlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorlarTableAdapter.Fill(this.elifUygunHastaneDataSet3.Doktorlar);
            // TODO: Bu kod satırı 'elifUygunHastaneDataSet2.Randevular' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.randevularTableAdapter.Fill(this.elifUygunHastaneDataSet2.Randevular);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();   
            adminPanel.Show();  
            this.Hide();
        }
    }
}
