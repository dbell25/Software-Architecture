using System;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public partial class uxProcessReturn : Form
    {
        IProcessReturn return_handler;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        /// <param name="rh"></param>
        public uxProcessReturn(IProcessReturn rh)
        {
            InitializeComponent();
            return_handler = rh;
        }

        /// <summary>
        /// Runs the form.
        /// </summary>
        public void Run()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Handles the Process Return click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void return_ProcessReturn_Click(object sender, EventArgs e)
        {
            int receipt_num = Convert.ToInt32(return_ReceiptVal.Value),
                itemNum = Convert.ToInt32(return_IDNumVal.Value),
                itemAmount = Convert.ToInt32(return_ItemAmount.Value);
            return_handler(receipt_num, itemNum, itemAmount);
        }
    }
}
