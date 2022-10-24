using Financiera.Commons.Processes;
using Financiera.Presentation.DependencyApp;
using Financiera.Presentation.Forms.Login;
using Financiera.Presentation.Forms.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Presentation
{ 
    internal static class Program
    {
        static public Thread? threadLog = new Thread(new ThreadStart(FormLog));
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread()]
        static void Main()
        {
            try
            {
                threadLog.Start();
            }
            catch { }

            
        }
        public static void FormLog()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
        public static void FormMain()
        {
            var sqlString = Connection.StringConnection;
            DependencyInject.Inyeccion(sqlString);
        }
    }
}
