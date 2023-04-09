using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Inquiry : Form
    {
        public Inquiry()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void labBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Inquiry_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "select * from TransactionTb1 where AccNum = '" + Login.AccountNumber + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                transactionDGV.DataSource = ds.Tables[0];
                transactionDGV.Columns["TId"].HeaderText = "业务号";
                transactionDGV.Columns["AccNum"].HeaderText = "账号";
                transactionDGV.Columns["Type"].HeaderText = "业务类型";
                transactionDGV.Columns["Amount"].HeaderText = "交易金额";
                transactionDGV.Columns["TDate"].HeaderText = "交易日期";
            }
            catch (Exception ex)
            {
                MessageBox.Show("连接数据库时发生错误！提示：" + ex.Message);
            }
            finally { conn.Close(); }
        }
    }
}
