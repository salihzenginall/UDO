using System;
using System.Windows.Forms;

namespace UDO
{
    static class Program
    {
        /// <summary>
        /// Uygulamanýn ana girdi noktasý.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Giriþ formunu baþlat
            Application.Run(new Forms.LoginForm());
        }
    }
}