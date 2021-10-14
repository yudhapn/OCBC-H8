using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using LoginApp.domain.usecase;

namespace LoginApp.presentation
{
    class LoginViewModel
    {
        private readonly LoginUseCase loginUseCase;
        public LoginViewModel(LoginUseCase loginUseCase) {
            this.loginUseCase = loginUseCase;
        }

        public string Login(string username, string password) =>
            loginUseCase.execute(username, password);
    }
}
