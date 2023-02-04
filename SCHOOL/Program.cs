using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SCHOOL
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

            var paramet = DateTime.ParseExact("12/01/2022", "MM/dd/yyyy", CultureInfo.InvariantCulture);
            var tod = DateTime.Today;
            if (tod < paramet)
            {
                Application.Run(new Login_Form());
            }
            else
            {

                Application.Run(new Session_Finished());
            }
        }
    }
}
