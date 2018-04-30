using System;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public class OutputForm
    {
        /// <summary>
        /// Shows the user an output dialog box.
        /// </summary>
        /// <param name="returnval"></param>
        /// <param name="status"></param>
        public void update(string returnval, State status)
        {
            MessageBox.Show(returnval);
        }
    }
}