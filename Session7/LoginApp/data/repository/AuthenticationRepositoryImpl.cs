using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApp.domain.repository;
using LoginApp.data.service;

namespace LoginApp.data.repository
{
    class AuthenticationRepositoryImpl : AuthenticationRepository
    {
        private readonly BankService bankService;

        public AuthenticationRepositoryImpl(BankService bankService) {
            this.bankService = bankService;
        }
        string AuthenticationRepository.Login(string username, string password)
        {
            bankService.ExecuteSelect($"SELECT * FROM user_info WHERE username='{username}' and password='{password}'");
            string message;
            Console.WriteLine($"bankService.Count() {bankService.Count()}");
            if (bankService.Count() == 1) {
                message = "You Succedded Login As " + bankService.Result(0, "name");
            } else
            {
                message = "Wrong Username And Password Combination";
            }
            return message;
        }

        string AuthenticationRepository.Register(string name, string username, string password)
        {
            bankService.Execute($"INSERT INTO user_info (id, name, username, password) VALUES (NULL, '{name}', '{username}', '{password}')");
            string message = "You succedded register as ";
            Console.WriteLine($"name: {name}, username: {username}, password: {password}");
            return message;

        }
    }
}
