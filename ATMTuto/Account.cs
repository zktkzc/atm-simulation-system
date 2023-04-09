using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMTuto
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tkzc\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int bal = 0;
            if (texAccountNum.Text.Trim() == "" || texAddr.Text.Trim() == "" || texLaName.Text.Trim() == "" || texName.Text.Trim() == "" || texOccupation.Text.Trim() == "" || texPhone.Text.Trim() == "" || texPin.Text.Trim() == "")
            {
                MessageBox.Show("信息缺失！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = @"insert into AccountTb1 values('" + texAccountNum.Text.Trim() + "','" + texName.Text.Trim() + "','" + texLaName.Text.Trim() + "','" + DobDate.Value.Date + "', '" + texPhone.Text.Trim() + "','" + texAddr.Text.Trim() + "','" + cbEducation.SelectedItem.ToString() + "','" + texOccupation.Text.Trim() + "'," + texPin.Text.Trim() + "," + bal + ")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("账户注册成功！！！");
                    conn.Close();
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("账户注册失败！！！提示：" + ex.Message);
                }
                finally { conn.Close(); }
            }
        }

        private void labLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
