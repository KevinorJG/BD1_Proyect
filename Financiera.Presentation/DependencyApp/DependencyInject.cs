using Financiera.AppCore.IServices;
using Financiera.AppCore.Services;
using Financiera.Domain.ContextDB;
using Financiera.Domain.Interfaces;
using Financiera.Infraestructure.Repository;
using Financiera.Presentation.Forms.Main;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Financiera.Presentation.DependencyApp
{
    internal class DependencyInject
    {
        static ServiceCollection? services { get; set; }
        [STAThread]
        public static void Inyeccion(string Connection)
        {

            services = new ServiceCollection();
            services.AddDbContext<FinancieraContext>(options =>
            {
                options.UseSqlServer(Connection);
            });
            services.AddSingleton<IFinancieraContext, FinancieraContext>();
            services.AddSingleton<IClientRepository, ClientRepository>();
            services.AddSingleton<IClientServices, ClientService>();

            services.AddSingleton<IAccountRepository, AccountRepository>();
            services.AddSingleton<IAccountServices, AccountService>();

            services.AddSingleton<ICardRepository, CardRepository>();
            services.AddSingleton<ICardServices, CardServices>();

            services.AddSingleton<MainForm>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            using (var serivceScope = services.BuildServiceProvider())
            {
                //Application.SetHighDpiMode(HighDpiMode.SystemAware);
                //Application.EnableVisualStyles();
                //Application.SetCompatibleTextRenderingDefault(false);
                var main = serivceScope.GetRequiredService<MainForm>();
                Application.Run(main);

            }

        }
    }
}
