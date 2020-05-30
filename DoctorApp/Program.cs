using System;
using System.IO;
using System.Windows.Forms;

namespace DoctorApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (File.Exists("directory.bin"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormStart());
            } 
        }
    }
}
