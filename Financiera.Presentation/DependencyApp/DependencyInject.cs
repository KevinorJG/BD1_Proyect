using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Financiera.Presentation.Forms.Main;
using Financiera.Domain.ContextDB;
using Financiera.Domain.Interfaces;
using Financiera.Infraestructure.Repository;
using Financiera.AppCore.IServices;
using Financiera.AppCore.Services;

namespace Financiera.Presentation.DependencyApp
{
    internal class DependencyInject
    {
        static ServiceCollection? services { get; set; }

        public static void Inyeccion(string Connection)
        {

            services = new ServiceCollection();
            services.AddDbContext<FinancieraContext>(options =>
            {
                options.UseSqlServer(Connection);
            });
            services.AddScoped<IFinancieraContext, FinancieraContext>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientServices, ClientService>();

            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountServices, AccountService>();

            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ICardServices, CardServices>();

            services.AddScoped<MainForm>();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            using (var serivceScope = services.BuildServiceProvider())
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                var main = serivceScope.GetRequiredService<MainForm>();
                Application.Run(main);

            }

        }
    }
}
