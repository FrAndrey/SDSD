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
            

         


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserHeight = float.Parse(heightBox.Text);
            UserWeight = float.Parse(weightBox.Text);
            double bmiImperial = (UserWeight * 703.0) / (UserHeight * UserHeight);
            double bmiMetric = UserWeight / (UserHeight * UserHeight);
            if (imperialButton.Checked)
            {
                outputBox.Text = bmiImperial.ToString();
            }
            else if (metricButton.Checked)
            {
                outputBox.Text = bmiMetric.ToString();

            }

            ClearForm();
        }

        private void ClearForm()
        {
            heightBox.Clear();
            weightBox.Clear();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            submitButton.Enabled = false;
        }

        private void HeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                float.Parse(heightBox.Text);
                submitButton.Enabled = true;
            }
            catch
            {
                submitButton.Enabled = false;
            }
        }
    }
}
