using System;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public partial class uxCreateRebate : Form
    {
        ISubmitRebate rebate_handler;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        /// <param name="rh"></param>
        public uxCreateRebate(ISubmitRebate rh)
        {
            InitializeComponent();
            rebate_handler = rh;
        }

        /// <summary>
        /// Runs the form.
        /// </summary>
        public void Run()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Handles the generate checks click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rebate_GenerateRebate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime cutOffDate = rebate_DateVal.Value;
                int receipt_num = Convert.ToInt32(rebate_ReceiptVal.Value);
                rebate_handler(cutOffDate, receipt_num);
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred. Please try again.");
            }

        }
    }
}
