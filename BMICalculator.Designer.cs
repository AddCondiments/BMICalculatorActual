namespace BMICalculator
{
    partial class BMICalculator
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
            this.ImperialRadio = new System.Windows.Forms.RadioButton();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.MetricRadio = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CalculateButtonPannel = new System.Windows.Forms.Panel();
            this.CalcuateButton = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ScaleCategoryTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.CalculateButtonPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalculateButtonPannel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResultTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ScaleCategoryTextBox, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 442);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ImperialRadio
            // 
            this.ImperialRadio.AutoSize = true;
            this.ImperialRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImperialRadio.Location = new System.Drawing.Point(154, 3);
            this.ImperialRadio.Name = "ImperialRadio";
            this.ImperialRadio.Size = new System.Drawing.Size(147, 67);
            this.ImperialRadio.TabIndex = 0;
            this.ImperialRadio.TabStop = true;
            this.ImperialRadio.Text = "Imperial";
            this.ImperialRadio.UseVisualStyleBackColor = true;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 146);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(98, 62);
            this.WeightLabel.TabIndex = 1;
            this.WeightLabel.Text = "The Weight";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeightTextBox.Location = new System.Drawing.Point(154, 105);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(147, 38);
            this.HeightTextBox.TabIndex = 0;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WeightTextBox.Location = new System.Drawing.Point(154, 178);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(147, 38);
            this.WeightTextBox.TabIndex = 1;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextBox.TextChanged += new System.EventHandler(this.WeightTextBox_TextChanged);
            // 
            // MetricRadio
            // 
            this.MetricRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetricRadio.Location = new System.Drawing.Point(3, 3);
            this.MetricRadio.Name = "MetricRadio";
            this.MetricRadio.Size = new System.Drawing.Size(145, 67);
            this.MetricRadio.TabIndex = 0;
            this.MetricRadio.TabStop = true;
            this.MetricRadio.Text = "Metric";
            this.MetricRadio.UseVisualStyleBackColor = true;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightLabel.Location = new System.Drawing.Point(3, 73);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(145, 73);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "The Height";
            // 
            // CalculateButtonPannel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateButtonPannel, 2);
            this.CalculateButtonPannel.Controls.Add(this.CalcuateButton);
            this.CalculateButtonPannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateButtonPannel.Location = new System.Drawing.Point(3, 222);
            this.CalculateButtonPannel.Name = "CalculateButtonPannel";
            this.CalculateButtonPannel.Size = new System.Drawing.Size(298, 67);
            this.CalculateButtonPannel.TabIndex = 2;
            // 
            // CalcuateButton
            // 
            this.CalcuateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalcuateButton.Location = new System.Drawing.Point(0, 0);
            this.CalcuateButton.Name = "CalcuateButton";
            this.CalcuateButton.Size = new System.Drawing.Size(298, 67);
            this.CalcuateButton.TabIndex = 0;
            this.CalcuateButton.Text = "Calculate BMI";
            this.CalcuateButton.UseVisualStyleBackColor = true;
            this.CalcuateButton.Click += new System.EventHandler(this.CalcuateButton_Click);
            // 
            // ResultTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ResultTextBox, 2);
            this.ResultTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResultTextBox.Enabled = false;
            this.ResultTextBox.Location = new System.Drawing.Point(3, 295);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(298, 67);
            this.ResultTextBox.TabIndex = 2;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScaleCategoryTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ScaleCategoryTextBox, 2);
            this.ScaleCategoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleCategoryTextBox.Location = new System.Drawing.Point(3, 368);
            this.ScaleCategoryTextBox.Multiline = true;
            this.ScaleCategoryTextBox.Name = "ScaleCategoryTextBox";
            this.ScaleCategoryTextBox.ReadOnly = true;
            this.ScaleCategoryTextBox.Size = new System.Drawing.Size(298, 71);
            this.ScaleCategoryTextBox.TabIndex = 3;
            this.ScaleCategoryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.Load += new System.EventHandler(this.BMICalculator_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.CalculateButtonPannel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricRadio;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.RadioButton ImperialRadio;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Panel CalculateButtonPannel;
        private System.Windows.Forms.Button CalcuateButton;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.TextBox ScaleCategoryTextBox;
    }
}

