using System;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            this.Hide();
            balance.Show();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            this.Hide();
            deposit.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            this.Hide();
            withdraw.Show();
        }

        private void btnFastCash_Click(object sender, EventArgs e)
        {
            FastCash fastCash = new FastCash();
            this.Hide();
            fastCash.Show();
        }

        private void btnInpuiry_Click(object sender, EventArgs e)
        {
            Inquiry inquiry = new Inquiry();
            this.Hide();
            inquiry.Show();
        }

        private void btnChangePIN_Click(object sender, EventArgs e)
        {
            ChangePIN changePIN = new ChangePIN();
            this.Hide();
            changePIN.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            labAccNum.Text = "账号：" + Login.AccountNumber;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
