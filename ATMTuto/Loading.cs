using System;
using System.Windows.Forms;

namespace ATMTuto
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int starting = 0;

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Random ran = new Random();
            starting += ran.Next(1, 6);
            progressBar1.Value = starting >= 100 ? 100 : starting;
            label2.Text = starting + "%";
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void Loading_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }
    }
}
