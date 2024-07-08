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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoktor addDoktor = new AddDoktor();
            addDoktor.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDoctor showDoctor = new ShowDoctor();   
            showDoctor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHastaAdd adminHastaAdd = new AdminHastaAdd();
            adminHastaAdd.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminRandevuShow adminRandevuShow = new AdminRandevuShow();
            adminRandevuShow.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminRandevuDoktor adminRandevuDoktor = new AdminRandevuDoktor();
             adminRandevuDoktor.Show();
            this.Hide();
        }
    }
}
