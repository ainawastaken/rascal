using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rascal_controller
{
    internal static class Program
    {
        public static List<string> errors = new List<string>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.FirstChanceException += FirstChanceExceptionHandler;
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionHandler;
            void FirstChanceExceptionHandler(object sender, FirstChanceExceptionEventArgs e)
            {
                Exception exception = (Exception)e.Exception;
                string errorMessage = exception.Message;
                string stackTrace = exception.StackTrace;
                errors.Add(errorMessage);
            }
            void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs e)
            {
                Exception exception = (Exception)e.ExceptionObject;
                string errorMessage = exception.Message;
                string stackTrace = exception.StackTrace;
                errors.Add(errorMessage);
            }

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Application.Run(new window());
        }
    }
}
