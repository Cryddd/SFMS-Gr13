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
    public partial class Incomes : Form
    {
        Functions Con;
        public Incomes()
        {
            Con = new Functions();
            InitializeComponent();
            ShowIncomes();
        }
        private void ShowIncomes()
        {
            string Query = "select * from IncomeTbl";
            IncomeList.DataSource = Con.GetData(Query);
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void incomebtn_Click(object sender, EventArgs e)
        {
            Incomes Obj = new Incomes();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (INameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string IName = INameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                    string Query = "INSERT INTO IncomeTbl VALUES ('{0}', {1}, '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date, Description);
                    Con.SetData(Query);
                    MessageBox.Show("Income Added!");
                    ShowIncomes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void IncomeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the click is on a valid row
            {
                INameTb.Text = IncomeList.Rows[e.RowIndex].Cells[1].Value.ToString();
                AmountTb.Text = IncomeList.Rows[e.RowIndex].Cells[2].Value.ToString();
                CatTb.Text = IncomeList.Rows[e.RowIndex].Cells[3].Value.ToString();
                // DateTb.Text = IncomeList.Rows[e.RowIndex].Cells[4].Value.ToString();
                DescTb.Text = IncomeList.Rows[e.RowIndex].Cells[5].Value.ToString();

                if (INameTb.Text == "")
                {
                    key = 0;
                }
                else
                {
                    key = Convert.ToInt32(IncomeList.Rows[e.RowIndex].Cells[0].Value);
                }
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (INameTb.Text == "" || AmountTb.Text == "" || CatTb.Text == "" || DescTb.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                try
                {
                    string IName = INameTb.Text;
                    int Amt = Convert.ToInt32(AmountTb.Text);
                    string Category = CatTb.Text;
                    string Description = DescTb.Text;
                   

                    string Query = "update IncomeTbl set IncName = '{0}', IncAmt = {1}, IncCat = '{2}', IncDate = '{3}', IncDesc = '{4}' where IncId = {5}";

                    Query = string.Format(Query, IName, Amt, Category, DateTb.Value.Date, Description, key);
                    Con.SetData(Query);
                    MessageBox.Show("Income Updated!");
                    ShowIncomes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select an Income.");
            }
            else
            {
                try
                {
                    string query = "DELETE FROM IncomeTbl WHERE IncId = @IncId";

                    // Use a parameterized query to avoid SQL injection
                    SqlParameter[] parameters = { new SqlParameter("@IncId", key) };

                    // Execute the delete query
                    Con.DeleteData(query, parameters);

                    MessageBox.Show("Income Deleted!");
                    ShowIncomes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
    }
}
