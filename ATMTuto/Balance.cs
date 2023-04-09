using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ATMTuto
{
    public partial class Balance : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void getBalance()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Balance from AccountTb1 where AccNum = '" + labAccNum.Text + "'", conn);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                labBalance.Text = "￥ " + dataTable.Rows[0][0].ToString();
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

        public Balance()
        {
            InitializeComponent();
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            labAccNum.Text = Login.AccountNumber;
            getBalance();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
