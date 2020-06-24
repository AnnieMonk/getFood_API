using getFood_UI.Home;
using getFood_UI.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getFood_UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

       
    }
}
