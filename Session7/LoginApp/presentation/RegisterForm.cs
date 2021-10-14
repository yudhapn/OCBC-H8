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

namespace LoginApp.presentation
{
    public partial class RegisterForm : Form
    {
        private readonly RegisterViewModel viewModel;
        public Form RefToForm1 { get; set; }
        public RegisterForm()
        {
            var host = Program.CreateHostBuilder(new string[0]).Build();
            viewModel = host.Services.GetRequiredService<RegisterViewModel>();
            InitializeComponent();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = isUserCredentialNotEmpty();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = isUserCredentialNotEmpty();
        }

        private void textBoxRetypePassword_TextChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = isUserCredentialNotEmpty();
            labelErrorMessage.Visible = isPasswordNotMatch();
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            buttonRegister.Enabled = isUserCredentialNotEmpty();
        }
        private bool isUserCredentialNotEmpty()
        {
            bool isNameNotEmpty = textBoxName.Text.ToString().Trim().Length != 0;
            bool isUsernameNotEmpty = textBoxUsername.Text.ToString().Trim().Length != 0;
            bool isPasswordNotEmpty = textBoxPassword.Text.ToString().Trim().Length != 0;
            bool isRetypePasswordNotEmpty = textBoxRetypePassword.Text.ToString().Trim().Length != 0;
            return isNameNotEmpty && isUsernameNotEmpty && isPasswordNotEmpty && isRetypePasswordNotEmpty;
        }

        private bool isPasswordNotMatch() {
            return textBoxPassword.Text.ToString().Trim() != textBoxRetypePassword.Text.ToString().Trim();
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.RefToForm1.Show();
            this.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            const string REGISTER_CONFIRM_MESSAGE = "Are you sure want to save this information?";
            var confirmResult = MessageBox.Show(REGISTER_CONFIRM_MESSAGE, "Confirm save!", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                string name = textBoxName.Text.ToString();
                string username = textBoxUsername.Text.ToString();
                string password = textBoxPassword.Text.ToString();
                string resultMessage = viewModel.Register(name, username, password);
                MessageBox.Show(resultMessage);
                this.RefToForm1.Show();
                this.Close();
            }
        }
    }
}
