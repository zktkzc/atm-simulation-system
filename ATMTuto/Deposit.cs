using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        int oldBalance, newBalance;

        private void addTransaction()
        {
            string trType = "存款";
            try
            {
                conn.Open();
                string qurey = "insert into TransactionTb1 values('" + Login.AccountNumber + "', '" + trType + "', '" + texAccount.Text.Trim() + "', '" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(qurey, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接数据库时发生错误！！！提示：" + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (texAccount.Text == "" || Convert.ToInt32(texAccount.Text) <= 0)
            {
                MessageBox.Show("请输入存款金额！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    newBalance = Convert.ToInt32(texAccount.Text.Trim());
                    int balance = oldBalance + newBalance;
                    string qurey = "update AccountTb1 set Balance = " + balance + " where AccNum = " + Login.AccountNumber;
                    SqlCommand cmd = new SqlCommand(qurey, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("存款交易成功！账户成功存入" + newBalance + "元");
                    conn.Close();
                    addTransaction();
                    Home home = new Home();
                    this.Hide();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接数据库时发生错误！！！提示：" + ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
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

        private void Deposit_Load(object sender, EventArgs e)
        {
            getBalance();
        }
    }
}
