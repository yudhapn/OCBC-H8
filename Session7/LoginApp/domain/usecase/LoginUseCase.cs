using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.domain.repository;

namespace LoginApp.domain.usecase
{
    class LoginUseCase
    {
        private readonly AuthenticationRepository repository;

        public LoginUseCase(AuthenticationRepository repository) {
            this.repository = repository;
        }
        public string execute(string username, string password) =>
            repository.Login(username, password);
    }
}
