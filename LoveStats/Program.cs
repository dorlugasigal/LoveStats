using LoveStats.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LoveStats
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            try
            {
                //Thread for singleton program
                bool appNotRunning;
                Mutex mtx = new Mutex(false, "LoveStats", out appNotRunning);
                if (appNotRunning)
                {
                    Application.Run(new frmSignIn_SignUp());
                    //Application.Run(new frmMain());
                }

            }
            catch (Exception)//ex
            {

                // Observer.WriteError(ex.Message, ex.StackTrace);
            }
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (e.ExceptionObject as Exception);
            // Observer.WriteError(ex.Message, ex.StackTrace);
        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //Observer.WriteError(e.Exception.Message, e.Exception.StackTrace);
        }
    }
}
