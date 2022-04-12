using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace MapaniApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CultureInfo current = Thread.CurrentThread.CurrentUICulture;
            if (current.TwoLetterISOLanguageName != "en-us")
            {
                CultureInfo newCulture = CultureInfo.CreateSpecificCulture("en-US");
                Thread.CurrentThread.CurrentUICulture = newCulture;
                // Make current UI culture consistent with current culture.
                Thread.CurrentThread.CurrentCulture = newCulture;
            }
            Console.WriteLine("The current UI culture is {0} [{1}]",
                              Thread.CurrentThread.CurrentUICulture.NativeName,
                              Thread.CurrentThread.CurrentUICulture.Name);
            Console.WriteLine("The current culture is {0} [{1}]",
                              Thread.CurrentThread.CurrentUICulture.NativeName,
                              Thread.CurrentThread.CurrentUICulture.Name);
            Application.Run(new Main());

        }
    }
}
