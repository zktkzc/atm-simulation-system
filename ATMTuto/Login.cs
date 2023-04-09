using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            this.Hide();
            account.Show();
        }

        public static string AccountNumber;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (texAccNum.Text.Trim() == "" || texPIN.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名或密码！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTb1 where AccNum = '" + texAccNum.Text.Trim() + "' and PIN = " + texPIN.Text.Trim(), conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        AccountNumber = texAccNum.Text.Trim();
                        Home home = new Home();
                        this.Hide();
                        home.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("登陆失败，请检查您输入的用户名或密码是否正确！！！");
                }
                finally { conn.Close(); }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
