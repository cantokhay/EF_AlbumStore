using EF_Maraton_DAL.Context;
using System;

namespace _01_Admin_Login
{
    public partial class AdminLogin : Form
    {
        AppDbContext context = new AppDbContext();
        public AdminLogin()
        {
            InitializeComponent();
        }
        private void AdminLogin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            AppDbContext context = new AppDbContext();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxUserName.Text.Trim();
            string password = tbxPassword.Text.Trim();

            var user = context.Admins.FirstOrDefault(a => a.Name == email && a.Password == password);

            if (user != null)
            {
                MessageBox.Show("Giriþ Baþarýlý");
                MainScreen userDashboard = new MainScreen();
                userDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya parola hatalý girildi.");
                tbxUserName.Text = tbxPassword.Text = "";
                return;
            }

        }
        private void lblSignup_Click(object sender, EventArgs e)
        {
            AdminSignUp adminSignup = new AdminSignUp();
            adminSignup.Show();
            this.Hide();
        }

        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked == true)
            {
                tbxPassword.UseSystemPasswordChar = false;

            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;
            }
        }
    }
}