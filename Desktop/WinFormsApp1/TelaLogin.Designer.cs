namespace WinFormsApp1
{
    partial class TelaLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtlogin = new TextBox();
            txtPassword = new TextBox();
            lblLogin = new Label();
            lblPassLogin = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(549, 357);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(277, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // txtlogin
            // 
            txtlogin.Location = new Point(549, 228);
            txtlogin.Name = "txtlogin";
            txtlogin.Size = new Size(277, 23);
            txtlogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(549, 292);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 23);
            txtPassword.TabIndex = 2;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(549, 210);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(37, 15);
            lblLogin.TabIndex = 3;
            lblLogin.Text = "Login";
            lblLogin.Click += label1_Click;
            // 
            // lblPassLogin
            // 
            lblPassLogin.AutoSize = true;
            lblPassLogin.Location = new Point(549, 274);
            lblPassLogin.Name = "lblPassLogin";
            lblPassLogin.Size = new Size(57, 15);
            lblPassLogin.TabIndex = 4;
            lblPassLogin.Text = "Password";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 802);
            Controls.Add(lblPassLogin);
            Controls.Add(lblLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtlogin);
            Controls.Add(btnLogin);
            Name = "TelaLogin";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtlogin;
        private TextBox txtPassword;
        private Label lblLogin;
        private Label lblPassLogin;
    }
}
