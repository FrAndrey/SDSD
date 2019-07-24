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
            this.weightLabel = new System.Windows.Forms.Label();
            this.metricButton = new System.Windows.Forms.RadioButton();
            this.heightLabel = new System.Windows.Forms.Label();
            this.imperialButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.17492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.35314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.47195F));
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.heightBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.weightBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metricButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.imperialButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.submitButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputBox, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 315);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(272, 113);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(0, 13);
            this.weightLabel.TabIndex = 12;
            // 
            // metricButton
            // 
            this.metricButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.metricButton, 2);
            this.metricButton.Location = new System.Drawing.Point(172, 3);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(106, 35);
            this.metricButton.TabIndex = 2;
            this.metricButton.Text = "Metric";
            this.metricButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metricButton.UseVisualStyleBackColor = true;
            this.metricButton.CheckedChanged += new System.EventHandler(this.MetricButton_CheckedChanged);
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(272, 56);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(0, 13);
            this.heightLabel.TabIndex = 12;
            // 
            // imperialButton
            // 
            this.imperialButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.imperialButton.Location = new System.Drawing.Point(14, 3);
            this.imperialButton.Name = "imperialButton";
            this.imperialButton.Size = new System.Drawing.Size(131, 35);
            this.imperialButton.TabIndex = 1;
            this.imperialButton.Text = "Imperial";
            this.imperialButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.imperialButton.UseVisualStyleBackColor = true;
            this.imperialButton.CheckedChanged += new System.EventHandler(this.ImperialButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Height";
            // 
            // weightBox
            // 
            this.weightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightBox.Location = new System.Drawing.Point(157, 100);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(76, 38);
            this.weightBox.TabIndex = 4;
            this.weightBox.TextChanged += new System.EventHandler(this.WeightBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Weight";
            // 
            // heightBox
            // 
            this.heightBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heightBox.Location = new System.Drawing.Point(157, 44);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(76, 38);
            this.heightBox.TabIndex = 3;
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
            // outputBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.outputBox, 3);
            this.outputBox.Enabled = false;
            this.outputBox.Location = new System.Drawing.Point(3, 203);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(296, 38);
            this.outputBox.TabIndex = 10;
            this.outputBox.Text = "Output(result)";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.submitButton, 3);
            this.submitButton.Location = new System.Drawing.Point(3, 157);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(296, 40);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Calculate!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.radioButton2);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
    }
}

