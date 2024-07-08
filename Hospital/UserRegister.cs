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
    public partial class UserRegister : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public UserRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogin UserLogin = new UserLogin();
            UserLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)+
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; //kullanıcı adı al
            string password = textBox2.Text; // şifre al
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO UserLogin (username, userpassword) VALUES (@username, @userpassword)"; // sql sorgusu
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@userpassword", password);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        // İşlem başarılıysa istenilen bir şey yapabilirsiniz
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


    }
    }

