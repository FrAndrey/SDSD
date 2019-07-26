using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calc
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void GreetingTimer_Tick(object sender, EventArgs e)
        {
            greetingTimer.Enabled = false;
            BMICalculator.mainForm.Show();
            this.Hide();
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            greetingTimer.Enabled = true;
          
        }
    }
}
