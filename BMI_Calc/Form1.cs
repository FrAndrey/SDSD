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
                double bmi = 0;
                double bmiImperial = Math.Round(((UserWeight * 703.0) / (UserHeight * UserHeight)), 1);
                double bmiMetric = Math.Round(UserWeight / (UserHeight * UserHeight), 1);
                if (imperialButton.Checked)
                {
                    bmi = bmiImperial;
                    outputBox.Text = bmiImperial.ToString();

                }
                if (metricButton.Checked)
                {
                    bmi = bmiMetric;
                    outputBox.Text = bmiMetric.ToString();
                }
            if (bmi <= 18.5)
            {
                recomendationBox.Text = "You need to enrich your diet. Your result is underweight.";
                outputBox.BackColor = Color.Yellow;
                recomendationBox.BackColor = Color.White;
            }
            if (bmi > 18.5 && bmi <= 24.9)
            {
                recomendationBox.Text = "You got a perfect balance, keep going!";        
                outputBox.BackColor = Color.GreenYellow;
                recomendationBox.BackColor = Color.White;
            }
            if (bmi > 24.9 && bmi <= 30)
            {
                recomendationBox.Text = "You are slightly out from your perfect form. Try to reduce input of Pizza";
                outputBox.BackColor = Color.Yellow;
                recomendationBox.BackColor = Color.White;
            }
            if (bmi > 30)
            {
                recomendationBox.Text = "You need to seriously reconsider your diet!";
                outputBox.BackColor = Color.Pink;
                recomendationBox.BackColor = Color.White;
            }
            if (bmi > 100 || bmi < 5)
            {
                outputBox.Text = "";
                outputBox.BackColor = Color.White;
                recomendationBox.Text = "Please enter the right values";
                recomendationBox.BackColor = Color.Pink;
            }

            ClearForm();
           

        }

        private void ClearForm()
        {
            heightBox.Clear();
            weightBox.Clear();
       
        }



      /// <summary>
      /// This is method to check input of Weight and Height Boxes
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>

        private void checkInput(object sender, EventArgs e)
        {   
            submitButton.Enabled = false;
            try
            {
                if (heightBox.Text != "" && weightBox.Text != "" && float.Parse(heightBox.Text) >0 && float.Parse(weightBox.Text) > 0)
                {
                    outputBox.BackColor = Color.White;
                    submitButton.Enabled = true;
                }
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
