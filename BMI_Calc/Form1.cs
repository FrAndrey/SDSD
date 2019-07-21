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
    public partial class MainForm : Form
    {
        public float UserHeight { get; set; }
        public float UserWeight { get; set; }

        public MainForm()
        {
            InitializeComponent();
            UserHeight = Convert.ToSingle(heightBox.Text);
            UserWeight = Convert.ToSingle(weightBox.Text);
            double bmi;
            if (imperialButton.Checked)
                bmi = (UserWeight * 703) / (UserHeight * UserHeight);
            else if (metricButton.Checked)
                bmi = UserWeight / (UserHeight * UserHeight);

           
        }
    }
}
