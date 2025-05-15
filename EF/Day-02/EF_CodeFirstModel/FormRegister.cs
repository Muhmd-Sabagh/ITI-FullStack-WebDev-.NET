using EF_CodeFirstModel.Models;
using System.Globalization;

namespace EF_CodeFirstModel
{
    public partial class FormRegister : Form
    {
        NewspaperContext NewspaperDb;
        public FormRegister()
        {
            InitializeComponent();
            NewspaperDb = new NewspaperContext();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var Authors = NewspaperDb.Authors;

            string authName = txtName.Text.Trim().ToLower();
            string authEmail = txtEmail.Text.Trim().ToLower();
            string authPass = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(authName) || authName.Length < 3)
                MessageBox.Show("Name must be at least 3 characters.");
            else if (string.IsNullOrWhiteSpace(authEmail) || !IsValidEmail(authEmail))
                MessageBox.Show("Email must be Valid ex: name@example.com.");
            else if (Authors.Any(a => a.Email == authEmail))
                MessageBox.Show("Email is already registered.");
            else if (string.IsNullOrWhiteSpace(authPass) || authPass.Length < 8)
                MessageBox.Show("Password must be at least 8 characters.");
            else
            {
                Authors.Add(new Author()
                {
                    Name = authName,
                    Email = authEmail,
                    Password = authPass
                });

                NewspaperDb.SaveChanges();

                txtName.Text = txtEmail.Text = txtPassword.Text = "";

                MessageBox.Show("Registered Successfully");
            }
        }

        private void ChkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                ChkShowPass.Text = "Hide";
            }
            else
            {
                txtPassword.PasswordChar = '•';
                ChkShowPass.Text = "Show";
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string authName = txtName.Text.Trim().ToLower();
            string authEmail = txtEmail.Text.Trim().ToLower();
            string authPass = txtPassword.Text;

            var auth = NewspaperDb.Authors.FirstOrDefault(a => a.Email == authEmail);

            if (auth == null)
                MessageBox.Show("Email is not registered.");
            else if (auth.Name != authName)
                MessageBox.Show("Incorrect Name.");
            else if (auth.Password != authPass)
                MessageBox.Show("Incorrect Password.");
            else
            {
                MessageBox.Show("Login Successfully");

                // Pass the user name in title case to home form
                FormHome homeForm = new FormHome(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(authName), auth.Id);

                // To Close all the app when home form closed
                homeForm.FormClosed += (s, args) => Application.Exit();

                homeForm.Show();
                this.Hide();
            }


        }

        // Helper Methods
        private bool IsValidEmail(string email)
        {
            return System.Text.RegularExpressions.Regex
                .IsMatch(
                    email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
                );
        }

    }
}
