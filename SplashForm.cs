using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Matthew Watada
 * 300832220
 * August 17th 2017
 * Trying to follow Tom's lab properly.
 * Version 0.3 (unclear) trying to get the splash form to work now.
 */

namespace BMICalculator
{
    public partial class SplashForm : Form
    {
        public BMICalculator BMICalculator
        {
            get
            {
                return Program.bmicalculator;
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// I forgot that the timer loops.
        /// I was like "why would you need to set it to false, or disable it
        /// if it's just gonna time out anyways..."
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            this.BMICalculator.Show();
            this.Hide();

            // Ok....

            SplashTimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
           
        }

    }
}
