using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.domain.repository;

namespace LoginApp.domain.usecase
{
    class RegisterUseCase
    {
        private AuthenticationRepository repository;
        public RegisterUseCase(AuthenticationRepository repository) {
            this.repository = repository;
        }
        public string execute(string name, string username, string password)  =>
            repository.Register(name, username, password);
    }
}
