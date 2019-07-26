using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Andrey Paramonov
/// 301038409
/// This is a BMI Calculator app that prompts user for body weight and height, and then
/// calculate Body Mass Index. This index is one of many health indicators
/// Last Modified : 26.07.2019
/// Andrey Fr, Programming 123
/// </summary>
namespace BMI_Calc
{
    static class BMICalculator
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


            Application.Run(greetingForm);
        }
    }
}
