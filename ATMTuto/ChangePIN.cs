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
    public partial class ChangePIN : Form
    {
        public ChangePIN()
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (texPin1.Text.Trim() == "" || texPin2.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空！！！");
            }
            else if (texPin1.Text.Trim() != texPin2.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update AccountTb1 set PIN = " + texPin1.Text.Trim() + " where AccNum = '" + Login.AccountNumber + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("密码修改成功，请重新登录！");
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接数据库时发生错误！提示：" + ex.Message);
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
