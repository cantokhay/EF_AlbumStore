namespace _01_Admin_Login
{
    partial class AdminSignUp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnSignup = new Button();
            tbxUserName = new TextBox();
            tbxPassword = new TextBox();
            tbxPasswordAgain = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(70, 16);
            label1.TabIndex = 0;
            label1.Text = "User Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 86);
            label2.Name = "label2";
            label2.Size = new Size(60, 16);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(90, 16);
            label3.TabIndex = 0;
            label3.Text = "Password Again :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(35, 155);
            label4.Name = "label4";
            label4.Size = new Size(79, 13);
            label4.TabIndex = 1;
            label4.Text = "Password Criterias : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(110, 155);
            label5.Name = "label5";
            label5.Size = new Size(98, 13);
            label5.TabIndex = 2;
            label5.Text = "1- Min 8 character length";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(110, 168);
            label6.Name = "label6";
            label6.Size = new Size(149, 13);
            label6.TabIndex = 2;
            label6.Text = "2- Min 2 UpperCase character is required";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(110, 181);
            label7.Name = "label7";
            label7.Size = new Size(150, 13);
            label7.TabIndex = 2;
            label7.Text = "3- Min 3 LowerCase character is required";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(110, 194);
            label8.Name = "label8";
            label8.Size = new Size(184, 13);
            label8.TabIndex = 2;
            label8.Text = "4- Min 2 Special character is required (ie. ! , : , + , *)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Stencil", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(73, 9);
            label9.Name = "label9";
            label9.Size = new Size(151, 19);
            label9.TabIndex = 3;
            label9.Text = "NEW USER SIGN UP";
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.PaleTurquoise;
            btnSignup.Font = new Font("Bauhaus 93", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.Tomato;
            btnSignup.Location = new Point(99, 218);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(100, 30);
            btnSignup.TabIndex = 4;
            btnSignup.Tag = "Signup";
            btnSignup.Text = "SIGN UP!";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // tbxUserName
            // 
            tbxUserName.Location = new Point(111, 46);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(160, 23);
            tbxUserName.TabIndex = 5;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(110, 84);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(160, 23);
            tbxPassword.TabIndex = 5;
            // 
            // tbxPasswordAgain
            // 
            tbxPasswordAgain.Location = new Point(111, 123);
            tbxPasswordAgain.Name = "tbxPasswordAgain";
            tbxPasswordAgain.Size = new Size(160, 23);
            tbxPasswordAgain.TabIndex = 5;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 224);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(50, 24);
            btnBack.TabIndex = 6;
            btnBack.Text = "BACK!";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(293, 260);
            Controls.Add(btnBack);
            Controls.Add(tbxPasswordAgain);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(btnSignup);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminSignUp";
            Text = "AdminSignUp";
            Load += AdminSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnSignup;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private TextBox tbxPasswordAgain;
        private Button btnBack;
    }
}