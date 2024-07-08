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
    public partial class AdminLogin : Form
    {
        private string connectionString = "Data Source=DESKTOP-06LT5PF\\SQLEXPRESS;Initial Catalog=ElifUygunHastane;Integrated Security=True";
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin UserLogin = new UserLogin();
            UserLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegister UserRegister = new UserRegister();
            UserRegister.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adminname = textBox1.Text; //kullanıcı adı
            string adminpassword = textBox2.Text; // şifre

            if (string.IsNullOrEmpty(adminname) || string.IsNullOrEmpty(adminpassword))
            {
                MessageBox.Show("Admin adı ve şifre boş olamaz.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM AdminLogin WHERE adminname = @adminname AND adminpassword = @adminpassword"; //sql sorgusu
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@adminname", adminname);
                    command.Parameters.AddWithValue("@adminpassword", adminpassword);
                    int result = (int)command.ExecuteScalar();

                    if (result > 0)
                    {
                        MessageBox.Show("Admin girişi başarılı.");
                        // İşlem başarılıysa istenilen bir şey yapabilirsiniz

                        AdminPanel AdminPanel = new AdminPanel();
                        AdminPanel.Show();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Admin girişi başarısız.");
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
