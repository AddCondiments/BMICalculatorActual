using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        // Private Instance variables
        private double _result;
        private double _weight;
        private double _height;
        private bool _imperial;
        private bool _metric;

        // Public Properties

        public double Result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
        public double Weight
        {
            get
            {
                return this._weight;
            }
            set
            {
                this._weight = value;
            }
        }
        public double Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        public bool Imperial
        {
            get 
            {
                return this._imperial;
            }
            set 
            {
                this._imperial = value;
            }
        }
        public bool Metric
        {
            get 
            {
                return this._metric;
            }
            set 
            {
                this._metric = value;
            }
        }

        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalcuateButton_Click(object sender, EventArgs e)
        {
            // Intialize Imperial and Metric as a checker to see whcih button is checked
            this.Imperial = this.ImperialRadio.Checked;
            this.Metric = this.MetricRadio.Checked;

            try
            {
                this.Weight = Convert.ToDouble(WeightTextBox.Text);
                this.Height = Convert.ToDouble(HeightTextBox.Text);
            }

            catch (Exception)
            {
                this.ResultTextBox.Text = "Not a number...";
                return;
            }

            // Depending on which is checked, use Imperial or Metric BMI calcuation formula

            if (Imperial)
            {
                this.Result = (Weight * 703) / (Height * Height);
            }
            else if (Metric)
            {
                this.Result = (Weight) / (Height * Height);
            }

            // Convert before sending it

            string resultString = this.Result.ToString("N2"); //Convert.ToString(this.Result);

            this.ResultTextBox.Text = resultString;
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
