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
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void CalcuateButton_Click(object sender, EventArgs e)
        {
            bool Imperial = ImperialRadio.Checked;
            bool Metric = MetricRadio.Checked;

            if (Imperial)
            {

            } 
            else if (Metric)
            {

            }
        }
    }
}
