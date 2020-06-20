using System;
using System.Windows.Forms;



namespace FlowCalculator
{
    static class FlowCalculatorProgram
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FlowCalculatorForm());
        }

    } // end static class FlowCalculatorProgram
}
