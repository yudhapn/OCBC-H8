using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using LoginApp.presentation;

namespace LoginApp
{
    public partial class LoginForm : Form
    {
        private readonly LoginViewModel viewModel;
        public LoginForm()
        {
            var host = Program.CreateHostBuilder(new string[0]).Build();
            viewModel = host.Services.GetRequiredService<LoginViewModel>();
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.RefToForm1 = this;
            registerForm.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.ToString();
            string password = textBoxPassword.Text.ToString();
            string resultMessage = viewModel.Login(username, password);
            MessageBox.Show(resultMessage);
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            buttonLogin.Enabled = isUserCredentialNotEmpty();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonLogin.Enabled = isUserCredentialNotEmpty();
        }

        private bool isUserCredentialNotEmpty()
        {
            bool isUsernameNotEmpty = textBoxUsername.Text.ToString().Trim().Length != 0;
            bool isPasswordNotEmpty = textBoxPassword.Text.ToString().Trim().Length != 0;
            return isUsernameNotEmpty && isPasswordNotEmpty;
        }
    }
}
