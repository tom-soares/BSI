using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleFinanceiro.Infra;

namespace ControleFinanceiro
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
            Login login = new Login();
            login.Show();
            //Dashboard d = new Dashboard();
            //d.Show();

            Application.Run();
        }
    }
}
