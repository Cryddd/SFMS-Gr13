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

namespace StudentsFinanceSystem
{
    public partial class Expenses : Form
    {
        Functions Con;
        public Expenses()
        {
            Con = new Functions();
            InitializeComponent();
            ShowExpenses();
     
        }

        private void ShowExpenses()
        {
            string Query = "select * from ExpenseTbl";
            ExpenseList.DataSource = Con.GetData(Query);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        private void addbtn_Click_1(object sender, EventArgs e)
        {
            if (ENameTb.Text == "" || ExpamountTb.Text == "" || ExpcatTb.Text == "" || ExpdescTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string IName = ENameTb.Text;
                    int Amt = Convert.ToInt32(ExpamountTb.Text);
                    string Category = ExpcatTb.Text;
                    string Description = ExpdescTb.Text;
                    string Query = "INSERT INTO ExpenseTbl VALUES ('{0}', {1}, '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, IName, Amt, Category, ExpdateTb.Value.Date, Description);
                    Con.SetData(Query);
                    MessageBox.Show("Expense Added!");
                    ShowExpenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void editbtn_Click(object sender, EventArgs e)
        {
            if (ENameTb.Text == "" || ExpamountTb.Text == "" || ExpcatTb.Text == "" || ExpdescTb.Text == "")
            {
                MessageBox.Show("Missing Data!");
            }
            else
            {
                try
                {
                    string IName = ENameTb.Text;
                    int Amt = Convert.ToInt32(ExpamountTb.Text);
                    string Category = ExpcatTb.Text;
                    string Description = ExpdescTb.Text;

                    string Query = "update ExpenseTbl set ExpName = '{0}', ExpAmt = {1}, ExpCat = '{2}', ExpDate = '{3}', ExpDesc = '{4}' where ExpId = {5}";

                    Query = string.Format(Query, IName, Amt, Category, ExpdateTb.Value.Date, Description, key);
                    Con.SetData(Query);
                    MessageBox.Show("Expenses Updated!");
                    ShowExpenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void ExpenseList_BtClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                ENameTb.Text = ExpenseList.Rows[e.RowIndex].Cells[1].Value.ToString();
                ExpamountTb.Text = ExpenseList.Rows[e.RowIndex].Cells[2].Value.ToString();
                ExpcatTb.Text = ExpenseList.Rows[e.RowIndex].Cells[3].Value.ToString();
                // DateTb.Text = IncomeList.Rows[e.RowIndex].Cells[4].Value.ToString();
                ExpdescTb.Text = ExpenseList.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (ENameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(ExpenseList.Rows[e.RowIndex].Cells[0].Value);
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an Expense.");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM ExpenseTbl WHERE ExpId = @ExpId";

                    // Use a parameterized query to avoid SQL injection
                    SqlParameter[] parameters = { new SqlParameter("@ExpId", key) };

                    // Execute the delete query
                    Con.DeleteData(query, parameters);

                    MessageBox.Show("Expense Deleted!");
                    ShowExpenses();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
