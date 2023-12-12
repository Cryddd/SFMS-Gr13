using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsFinanceSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void X_Click(object sender, EventArgs e)
        {

        }

        private void X_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else if (UnameTb.Text == "Admin" &&  PasswordTb.Text == "Admin")
            {
                Incomes Obj = new Incomes();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong User Name or Password!");
            }
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
