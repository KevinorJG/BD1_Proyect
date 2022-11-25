using Financiera.Commons.Processes;
using Financiera.Presentation.DependencyApp;
using Financiera.Presentation.Forms.Login;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Financiera.Presentation
{
    internal static class Program
    {
        public static Thread? threadLog;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
       // [STAThread()]
        [STAThreadAttribute()]
        static void Main()
        {
           
            try
            {               
                threadLog = new Thread(new ThreadStart(FormLog));
                threadLog.SetApartmentState(ApartmentState.STA);
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
            if(!String.IsNullOrWhiteSpace(Connection.StringConnection))
            {
                FormMain();
            }
            
        }
        public static void FormMain()
        {
            var sqlString = Connection.StringConnection;
            DependencyInject.Inyeccion(sqlString);
        }
    }
}
