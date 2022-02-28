using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyelvVizsgak
{
    static class Program
    {
        internal static string ConnectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;" +
                "Initial Catalog=nyelviskola;" +
                "Integrated Security=True;";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
