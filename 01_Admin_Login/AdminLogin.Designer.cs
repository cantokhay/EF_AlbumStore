namespace _01_Admin_Login
{
    partial class AdminLogin
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
            label1 = new Label();
            label2 = new Label();
            tbxUserName = new TextBox();
            tbxPassword = new TextBox();
            ckbShowPassword = new CheckBox();
            btnLogin = new Button();
            lblSignup = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 32);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(99, 29);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(100, 23);
            tbxUserName.TabIndex = 1;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(99, 60);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '*';
            tbxPassword.Size = new Size(100, 23);
            tbxPassword.TabIndex = 1;
            // 
            // ckbShowPassword
            // 
            ckbShowPassword.AutoSize = true;
            ckbShowPassword.Location = new Point(91, 89);
            ckbShowPassword.Name = "ckbShowPassword";
            ckbShowPassword.Size = new Size(108, 19);
            ckbShowPassword.TabIndex = 2;
            ckbShowPassword.Text = "Show Password";
            ckbShowPassword.UseVisualStyleBackColor = true;
            ckbShowPassword.CheckedChanged += ckbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleTurquoise;
            btnLogin.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Tomato;
            btnLogin.Location = new Point(53, 114);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Tag = "login";
            btnLogin.Text = "LOGIN!";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblSignup.Location = new Point(53, 167);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(89, 15);
            lblSignup.TabIndex = 4;
            lblSignup.Text = "Click To SignUp";
            lblSignup.Click += lblSignup_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(224, 202);
            Controls.Add(lblSignup);
            Controls.Add(btnLogin);
            Controls.Add(ckbShowPassword);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminLogin";
            Text = "Form1";
            Load += AdminLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private CheckBox ckbShowPassword;
        private Button btnLogin;
        private Label lblSignup;
    }
}