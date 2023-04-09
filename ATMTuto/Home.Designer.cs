namespace ATMTuto
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnFastCash = new Guna.UI2.WinForms.Guna2Button();
            this.btnInpuiry = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangePIN = new Guna.UI2.WinForms.Guna2Button();
            this.btnBalance = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labAccNum = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(933, 146);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(888, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 3;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Select The Service You Need";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(308, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "请选择所需服务";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BorderColor = System.Drawing.Color.Transparent;
            this.btnDeposit.BorderThickness = 3;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposit.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeposit.Location = new System.Drawing.Point(161, 229);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(235, 66);
            this.btnDeposit.TabIndex = 6;
            this.btnDeposit.Text = "存款 Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BorderColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BorderThickness = 3;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnWithdraw.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnWithdraw.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnWithdraw.Location = new System.Drawing.Point(549, 229);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(235, 66);
            this.btnWithdraw.TabIndex = 7;
            this.btnWithdraw.Text = "取款 Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnFastCash
            // 
            this.btnFastCash.BorderColor = System.Drawing.Color.Transparent;
            this.btnFastCash.BorderThickness = 3;
            this.btnFastCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFastCash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFastCash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFastCash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFastCash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFastCash.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnFastCash.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnFastCash.ForeColor = System.Drawing.Color.White;
            this.btnFastCash.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnFastCash.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFastCash.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFastCash.Location = new System.Drawing.Point(161, 362);
            this.btnFastCash.Name = "btnFastCash";
            this.btnFastCash.Size = new System.Drawing.Size(235, 66);
            this.btnFastCash.TabIndex = 6;
            this.btnFastCash.Text = "快速取款 Fast Cash";
            this.btnFastCash.Click += new System.EventHandler(this.btnFastCash_Click);
            // 
            // btnInpuiry
            // 
            this.btnInpuiry.BorderColor = System.Drawing.Color.Transparent;
            this.btnInpuiry.BorderThickness = 3;
            this.btnInpuiry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInpuiry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInpuiry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInpuiry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInpuiry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInpuiry.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnInpuiry.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnInpuiry.ForeColor = System.Drawing.Color.White;
            this.btnInpuiry.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnInpuiry.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnInpuiry.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnInpuiry.Location = new System.Drawing.Point(549, 362);
            this.btnInpuiry.Name = "btnInpuiry";
            this.btnInpuiry.Size = new System.Drawing.Size(235, 66);
            this.btnInpuiry.TabIndex = 7;
            this.btnInpuiry.Text = "查询 Inquiry";
            this.btnInpuiry.Click += new System.EventHandler(this.btnInpuiry_Click);
            // 
            // btnChangePIN
            // 
            this.btnChangePIN.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangePIN.BorderThickness = 3;
            this.btnChangePIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePIN.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePIN.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnChangePIN.ForeColor = System.Drawing.Color.White;
            this.btnChangePIN.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePIN.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnChangePIN.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePIN.Location = new System.Drawing.Point(161, 495);
            this.btnChangePIN.Name = "btnChangePIN";
            this.btnChangePIN.Size = new System.Drawing.Size(235, 66);
            this.btnChangePIN.TabIndex = 6;
            this.btnChangePIN.Text = "修改密码 Change PIN";
            this.btnChangePIN.Click += new System.EventHandler(this.btnChangePIN_Click);
            // 
            // btnBalance
            // 
            this.btnBalance.BorderColor = System.Drawing.Color.Transparent;
            this.btnBalance.BorderThickness = 3;
            this.btnBalance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBalance.FillColor = System.Drawing.Color.DarkSlateGray;
            this.btnBalance.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.btnBalance.ForeColor = System.Drawing.Color.White;
            this.btnBalance.HoverState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnBalance.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnBalance.HoverState.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBalance.Location = new System.Drawing.Point(549, 495);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(235, 66);
            this.btnBalance.TabIndex = 7;
            this.btnBalance.Text = "余额 Balance";
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 641);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(933, 20);
            this.guna2Panel2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(397, 594);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "退出 Logout";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labAccNum
            // 
            this.labAccNum.AutoSize = true;
            this.labAccNum.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.labAccNum.ForeColor = System.Drawing.Color.Gray;
            this.labAccNum.Location = new System.Drawing.Point(359, 163);
            this.labAccNum.Name = "labAccNum";
            this.labAccNum.Size = new System.Drawing.Size(237, 35);
            this.labAccNum.TabIndex = 2;
            this.labAccNum.Text = "Account Number";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labAccNum);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.btnInpuiry);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnChangePIN);
            this.Controls.Add(this.btnFastCash);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnFastCash;
        private Guna.UI2.WinForms.Guna2Button btnInpuiry;
        private Guna.UI2.WinForms.Guna2Button btnChangePIN;
        private Guna.UI2.WinForms.Guna2Button btnBalance;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labAccNum;
    }
}