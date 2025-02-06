using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new FrmSAURegister());
=======
            Application.Run(new FrmMainMenu());
>>>>>>> 05fa6cb822ed4801b7e94b38d3c7df1dcaadeb0f
        }
    }
}
