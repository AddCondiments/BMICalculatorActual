using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    /*
     * Matthew Watada
     * 300832220
     * (!!!Note for TOM!!!) - I started this in B3
     * on a computer that only 
     * had VS 2012 with no github extension
     * This was the original v0.1
     */
    static class Program
    {
        public static BMICalculator bmicalculator;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bmicalculator = new BMICalculator();

            Application.Run(new BMICalculator());
        }
    }
}
