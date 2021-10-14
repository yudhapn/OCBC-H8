using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using LoginApp.data.repository;
using LoginApp.domain.repository;
using LoginApp.domain.usecase;
using LoginApp.presentation;
using LoginApp.data.service;

namespace LoginApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices(services =>
            {
                services.AddTransient<AuthenticationRepository, AuthenticationRepositoryImpl>();
                services.AddTransient<LoginUseCase>();
                services.AddTransient<RegisterUseCase>();
                services.AddTransient<LoginViewModel>();
                services.AddTransient<RegisterViewModel>();
                services.AddSingleton<BankService>();
            });
    }
}
