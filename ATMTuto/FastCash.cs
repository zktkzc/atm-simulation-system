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

namespace ATMTuto
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        int oldBalance;

        private void FastCash_Load(object sender, EventArgs e)
        {
            getBalance();
            labBalance.Text = oldBalance.ToString() + " 元";
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 100);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 500);
        }

        private void btn1000_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 1000);
        }

        private void btn2000_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 2000);
        }

        private void btn5000_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 5000);
        }

        private void btn10000_Click(object sender, EventArgs e)
        {
            withdraw(oldBalance, 10000);
        }

        private void getBalance()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTb1 where AccNum = '" + Login.AccountNumber + "'", conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                oldBalance = Convert.ToInt32(dataTable.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询数据库失败！！！提示：" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void withdraw(int oldBalance, int newBalance)
        {
            if (oldBalance < newBalance)
                MessageBox.Show("账户余额不足，请重新选择！！！");
            else
            {
                try
                {
                    conn.Open();
                    int balance = oldBalance - newBalance;
                    string qurey = "update AccountTb1 set Balance = " + balance + " where AccNum = " + Login.AccountNumber;
                    SqlCommand cmd = new SqlCommand(qurey, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("取款交易成功！账户成功取出" + newBalance + "元");
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接数据库时发生错误！！！提示：" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
