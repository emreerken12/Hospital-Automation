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
    public partial class ShowDoctor : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public ShowDoctor()
        {
            InitializeComponent();
        }

        private void ShowDoctor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'elifUygunHastaneDataSet.Doktorlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.doktorlarTableAdapter.Fill(this.elifUygunHastaneDataSet.Doktorlar);

        }


        private DataTable GetDoktorlar()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Doktorlar";
                    SqlCommand command = new SqlCommand(query, connection);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

            return dataTable;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            string doctorname = textBox1.Text;
            string doctorsname = textBox2.Text;
            string doctortc = maskedTextBox1.Text;
            string doctortitle = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrEmpty(doctorname) || string.IsNullOrEmpty(doctorsname) || string.IsNullOrEmpty(doctortc) || string.IsNullOrEmpty(doctortitle))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Doktorlar SET doctorname = @doctorname, doctorsname = @doctorsname, doctortitle = @doctortitle WHERE doctortc = @doctortc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@doctorname", doctorname);
                    command.Parameters.AddWithValue("@doctorsname", doctorsname);
                    command.Parameters.AddWithValue("@doctortitle", doctortitle);
                    command.Parameters.AddWithValue("@doctortc", doctortc);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doktor güncelleme başarılı.");
                        // Eğer isteniyorsa, güncelledikten sonra bir işlem yapılabilir.
                        GetDoktorlar();
                    }
                    else
                    {
                        MessageBox.Show("Doktor güncelleme başarısız.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string doctortc = maskedTextBox1.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Doktorlar WHERE doctortc = @doctortc";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@doctortc", doctortc);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doktor silme başarılı.");
                        // Eğer isteniyorsa, silindikten sonra bir işlem yapılabilir.
                        GetDoktorlar();
                    }
                    else
                    {
                        MessageBox.Show("Doktor silme başarısız.");
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
