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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace ElifUygunHastane
{
    public partial class UserLogin : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public UserLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegister UserRegister = new UserRegister();
            UserRegister.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text; //kullanıcı adı 
            string password = textBox2.Text; // şifre

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
                    string query = "SELECT COUNT(*) FROM UserLogin WHERE username = @username AND userpassword = @userpassword"; // sql sorgusu
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@userpassword", password);
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Giriş başarılı.");
                        // İşlem başarılıysa istenilen bir şey yapabilirsiniz

                        UserPanel UserPanel = new UserPanel();
                        UserPanel.Show(); // Yeni formu gösterir
                        this.Hide(); // Mevcut formu gizler (isterseniz)  // giriş başarılıysa geçeceği form.


                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
    }

