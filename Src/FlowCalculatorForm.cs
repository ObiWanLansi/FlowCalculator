using System.Windows.Forms;



namespace FlowCalculator
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class FlowCalculatorForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowCalculatorForm"/> class.
        /// </summary>
        public FlowCalculatorForm()
        {
            InitializeComponent();


            // Zum Debuggen setzten wir mal ein paar Werte
            this.mtbDuesenDurch.Text = "00,40";
            this.mtbQuellung.Text = "00,48";

            this.mtbMeasurement1.Text = "00,96";
            this.mtbMeasurement2.Text = "00,96";
            this.mtbMeasurement3.Text = "00,96";
            this.mtbMeasurement4.Text = "00,96";
            this.mtbMeasurement5.Text = "00,96";
            this.mtbMeasurement6.Text = "00,96";
            this.mtbMeasurement7.Text = "00,96";
            this.mtbMeasurement8.Text = "00,96";
            this.mtbTotal.Text = "07,68";
            this.mtbAverage.Text = "00,96";
        }

    } // end public partial class FlowCalculatorForm
}
