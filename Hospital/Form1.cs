using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElifUygunHastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        // Admin giriş
        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin AdminLogin = new AdminLogin();
            AdminLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }


        // User Giriş
        private void button3_Click(object sender, EventArgs e)
        {
            UserLogin UserLogin = new UserLogin();
            UserLogin.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }


        // User Kayıt
        private void button2_Click(object sender, EventArgs e)
        {
            UserRegister UserRegister = new UserRegister();
            UserRegister.Show(); // Yeni formu gösterir
            this.Hide(); // Mevcut formu gizler (isterseniz)
        }
    }
}
