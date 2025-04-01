using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinanceApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            if(Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //LauncherForm launchForm = new LauncherForm();
            LauncherForm launchForm = new LauncherForm();
            launchForm.Show();

            // The application is seperate from the Forms
            Application.Run(); 
        }

        //Retrieves user32.dll which can be used to get dpi settings
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        //SetProcessDPIAware() is from the dll file, the extern keyword allows us to use it in Main
        public static extern bool SetProcessDPIAware();
    }
}
