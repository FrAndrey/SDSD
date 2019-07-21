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
            double bmiImperial = Math.Round(((UserWeight * 703.0) / (UserHeight * UserHeight)),1);
            double bmiMetric = Math.Round(UserWeight / (UserHeight * UserHeight),1);
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ImperialButton_CheckedChanged(object sender, EventArgs e)
        {
            heightLabel.Text = "Inches";
            weightLabel.Text = "Pounds";
        }

        private void MetricButton_CheckedChanged(object sender, EventArgs e)
        {
            heightLabel.Text = "Meters";
            weightLabel.Text = "Kilograms";
        }
    }
}
