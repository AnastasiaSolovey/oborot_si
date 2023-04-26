using Oborot_SI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avionika_Si.Helpers;

namespace Avionika_Si
{
    internal static class Program
    {
        public static DatabaseHelper DbHelper = new DatabaseHelper();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Oborot_SI.MainMenu());
            Application.Run(new Oborot_SI.Schedule());
        }
    }
}
