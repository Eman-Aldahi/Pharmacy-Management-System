using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_TIC_IPI201_C2_F24_eman_117001
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // إعدادات اللغة والتاريخ (لا تحذفها لضمان استقرار البرنامج)
            var culture = new System.Globalization.CultureInfo("en-US");
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Screen());
        }
    }
}
