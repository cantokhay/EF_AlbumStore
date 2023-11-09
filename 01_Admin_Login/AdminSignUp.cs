using EF_Maraton_DAL.Context;
using EF_Maraton_DAL.Entites;

namespace _01_Admin_Login
{
    public partial class AdminSignUp : Form
    {
        AppDbContext context;
        public AdminSignUp()
        {
            InitializeComponent();
        }

        private void AdminSignUp_Load(object sender, EventArgs e)
        {
            new AppDbContext();
            this.CenterToScreen();
            tbxPassword.UseSystemPasswordChar = true;
            tbxPasswordAgain.UseSystemPasswordChar = true;

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            AppDbContext context = new AppDbContext();

            Admin admin = new Admin();

            try
            {
                var CheckPerson = context.Admins.Where(x => x.Name == tbxUserName.Text).FirstOrDefault();

                if (CheckPerson != null)
                {
                    MessageBox.Show("This Username has been created!!");
                    return;
                }


                if (tbxUserName.Text == string.Empty)
                {
                    MessageBox.Show("Please submit valid User Name");
                    return;
                }

                else if (tbxPassword.Text.Length < 8) //TODO password Criterias
                {
                    MessageBox.Show("Please enter a Vaild Password");
                    tbxPassword.Text = "";
                    return;
                }

                else if (tbxPassword.Text != tbxPasswordAgain.Text)
                {
                    MessageBox.Show("Please Re-enter Your Password Correct!!");
                    tbxPasswordAgain.Text = "";
                    return;
                }

                else
                {
                    admin = new Admin()
                    {
                        Name = tbxUserName.Text,
                        Password = tbxPassword.Text
                    };
                    MessageBox.Show("Your Account created Succesfully!!");
                    btnSignup.Enabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "There is something wrong :(((");
            }


            context.Admins.Add(admin);

            context.SaveChanges();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            this.Hide();
            adminLogin.Show();

        }
    }
}
