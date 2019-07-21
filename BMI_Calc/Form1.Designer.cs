namespace BMI_Calc
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imperialButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.metricButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 328);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(233, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // imperialButton
            // 
            this.imperialButton.Location = new System.Drawing.Point(12, 44);
            this.imperialButton.Name = "imperialButton";
            this.imperialButton.Size = new System.Drawing.Size(128, 35);
            this.imperialButton.TabIndex = 1;
            this.imperialButton.TabStop = true;
            this.imperialButton.Text = "Imperial";
            this.imperialButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(338, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(207, 155);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metric";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Weight";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(141, 127);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(89, 38);
            this.heightBox.TabIndex = 3;
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(141, 164);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(89, 38);
            this.weightBox.TabIndex = 4;
            this.weightBox.TextChanged += new System.EventHandler(this.WeightBox_TextChanged);
            // 
            // outputBox
            // 
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(35, 208);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(196, 38);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "Output(result)";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(53, 252);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(167, 43);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Calculate!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // metricButton
            // 
            this.metricButton.Location = new System.Drawing.Point(146, 44);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(128, 35);
            this.metricButton.TabIndex = 2;
            this.metricButton.TabStop = true;
            this.metricButton.Text = "Metric";
            this.metricButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.metricButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.imperialButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton imperialButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox heightBox;
        private System.Windows.Forms.TextBox weightBox;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.RadioButton metricButton;
    }
}

