using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calc
{
    static class Program
    {
        public static GreetingForm greetingForm;
        public static MainForm mainForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            greetingForm = new GreetingForm();
            mainForm = new MainForm();


            //Application.Run(new MainForm());
        }
    }
}
