﻿namespace ATMTuto
{
    partial class Withdraw
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.texAccount = new System.Windows.Forms.TextBox();
            this.labBack = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labBalance = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 553);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(718, 24);
            this.guna2Panel2.TabIndex = 15;
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
            this.guna2Panel1.Size = new System.Drawing.Size(718, 120);
            this.guna2Panel1.TabIndex = 14;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(670, 3);
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
            this.label2.Location = new System.Drawing.Point(164, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATM SIMULATION SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 30F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(208, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATM 模拟系统";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.AutoRoundedCorners = true;
            this.btnWithdraw.BorderColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.BorderRadius = 21;
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
            this.btnWithdraw.Location = new System.Drawing.Point(231, 432);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(298, 45);
            this.btnWithdraw.TabIndex = 30;
            this.btnWithdraw.Text = "取款 Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // texAccount
            // 
            this.texAccount.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.texAccount.Location = new System.Drawing.Point(233, 333);
            this.texAccount.Name = "texAccount";
            this.texAccount.Size = new System.Drawing.Size(296, 34);
            this.texAccount.TabIndex = 29;
            // 
            // labBack
            // 
            this.labBack.AutoSize = true;
            this.labBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labBack.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labBack.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labBack.Location = new System.Drawing.Point(323, 501);
            this.labBack.Name = "labBack";
            this.labBack.Size = new System.Drawing.Size(103, 27);
            this.labBack.TabIndex = 28;
            this.labBack.Text = "返回 Back";
            this.labBack.Click += new System.EventHandler(this.labBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(184, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 27);
            this.label5.TabIndex = 24;
            this.label5.Text = "Please enter the withdraw amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(133, 364);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 25F);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(219, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 45);
            this.label4.TabIndex = 26;
            this.label4.Text = "请输入取款金额";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(131, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(212, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 27);
            this.label6.TabIndex = 26;
            this.label6.Text = "当前可用余额：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(213, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Available Balance";
            // 
            // labBalance
            // 
            this.labBalance.AutoSize = true;
            this.labBalance.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.labBalance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labBalance.Location = new System.Drawing.Point(353, 236);
            this.labBalance.Name = "labBalance";
            this.labBalance.Size = new System.Drawing.Size(85, 27);
            this.labBalance.TabIndex = 26;
            this.labBalance.Text = "Balance";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 577);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.texAccount);
            this.Controls.Add(this.labBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labBalance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private System.Windows.Forms.TextBox texAccount;
        private System.Windows.Forms.Label labBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labBalance;
    }
}