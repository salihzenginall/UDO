using System;
using System.Windows.Forms;

namespace UDO
{
    static class Program
    {
        /// <summary>
        /// Uygulaman�n ana girdi noktas�.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Giri� formunu ba�lat
            Application.Run(new Forms.LoginForm());
        }
    }
}