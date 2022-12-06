using System;
using System.Windows.Forms;

namespace APx500_Samples
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new DisplayMeterResults());
        }
    }
}
