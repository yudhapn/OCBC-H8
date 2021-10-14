using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using LoginApp.domain.usecase;

namespace LoginApp.presentation
{
    class RegisterViewModel
    {
        private readonly RegisterUseCase registerUseCase;
        public RegisterViewModel(RegisterUseCase registerUseCase) {
            this.registerUseCase = registerUseCase;
        }

        public string Register(string name, string username, string password) =>
            registerUseCase.execute(name, username, password);
    }
}
