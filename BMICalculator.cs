using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Matthew Watada
 * 300832220
 * August 17th 2017
 * v0.2 This was a pain in the ass, but it's done....
 * Created most of the event handling from the calculate button.
 */

namespace BMICalculator
{
    public partial class BMICalculator : Form
    {
        #region Variables and Properties
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
        #endregion

        public BMICalculator()
        {
            InitializeComponent();
        }

        #region CalculateButton_Click

        /// <summary>
        /// Might as well be able to check every single control in one function roght?
        /// I mean, there's only one button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                this.ResultTextBox.Text = "Can't calculate...";
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

            if (this.Result < 18.5)
            {
                ScaleCategoryTextBox.Text = "You're underweight...";
            } else if (this.Result >= 18.5 && this.Result <= 24.9)
            {
                ScaleCategoryTextBox.Text = "Weight is normal...";
            } else if (this.Result >= 25 && this.Result <= 29.9)
            {
                ScaleCategoryTextBox.Text = "You're overwieght...";
            }  else if(this.Result >= 30)
            {
                ScaleCategoryTextBox.Text = "xXx_O B E S E_xXx";
            }

        }
        #endregion

        private void BMICalculator_Load(object sender, EventArgs e)
        {

        }
        #region HeightTextBox Input Validation
        /// <summary>
        /// So Abby agreed to keep an eye on me and try and catch errors.
        /// He suggested using regex to validate numbers.
        /// Who would want to make 2 separate (26 case) switch cases for A-Z and a-z?...
        /// On the stack overflow page, somebody pointed out that the original solution wouldn't work.
        /// Originally, the statement after "MessageBox.Show()" would only delete the last input in the string.
        /// I used the ".Clear()" function, but took a while to figure out that I needed the "()".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.HeightTextBox.Text == "")
            {
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(this.HeightTextBox.Text, @"^(?:\d*\.)?\d+$"))
            {

                MessageBox.Show("Numbers P L E A S E!");
                this.HeightTextBox.Clear();
            }
        }
        #endregion
        #region WeightTextbox Input Validation
        private void WeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.WeightTextBox.Text == "")
            {
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(this.WeightTextBox.Text, @"^(?:\d*\.)?\d+$"))
            {

                MessageBox.Show("Numbers P L E A S E!");
                this.WeightTextBox.Clear();
            }
        }
        #endregion
    }
}
