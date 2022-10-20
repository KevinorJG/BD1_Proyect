using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using Financiera.Presentation.Forms.Main;

namespace Financiera.Presentation.DependencyApp
{
    internal class DependencyInject
    {
        static ServiceCollection? services { get; set; }

        public static void Inyeccion(string Connection)
        {

            services = new ServiceCollection();
            //services.AddDbContext<ENSUENO_DBContext>(options =>
            //{
            //    options.UseSqlServer(Connection);
            //});
            //services.AddScoped<IClientRepository, ClientRepository>();
            //services.AddScoped<IClientServices, ClientService>();

            //services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IEmployeeServices, EmployeeService>();

            //services.AddScoped<IProductRepository, ProductRepository>();
            //services.AddScoped<IProductServices, ProductService>();

            //services.AddScoped<IFactureRepository, FactureRepository>();
            //services.AddScoped<IFactureServices, FactureService>();

            //services.AddScoped<IDetail_FactureRepository, Detail_FactureRepository>();
            //services.AddScoped<IDetail_FactureServices, Detail_FactureService>();


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
