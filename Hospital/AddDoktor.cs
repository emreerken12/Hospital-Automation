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
    public partial class AddDoktor : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public AddDoktor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel AdminPanel = new AdminPanel();
            AdminPanel.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string doctorname = textBox1.Text; //adı    
            string doctorsname = textBox2.Text; //soyadı
            string doctortc = maskedTextBox1.Text; // tcsi
            string doctortitle = comboBox1.SelectedItem.ToString(); // ünvanı

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
                    string query = "INSERT INTO Doktorlar (doctorname, doctorsname, doctortc, doctortitle) VALUES (@doctorname, @doctorsname, @doctortc, @doctortitle)"; // sql sorgusu
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@doctorname", doctorname);
                    command.Parameters.AddWithValue("@doctorsname", doctorsname);
                    command.Parameters.AddWithValue("@doctortc", doctortc);
                    command.Parameters.AddWithValue("@doctortitle", doctortitle);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Doktor ekleme başarılı.");
                        // Eğer isteniyorsa, ekledikten sonra bir işlem yapılabilir.
                    }
                    else
                    {
                        MessageBox.Show("Doktor ekleme başarısız.");
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

