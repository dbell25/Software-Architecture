using System;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public partial class uxGenerateChecks : Form
    {
        IGenerateRebate generate_checks_handler;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        /// <param name="generate_checks_handler"></param>
        public uxGenerateChecks(IGenerateRebate generate_checks_handler)
        {
            this.generate_checks_handler = generate_checks_handler;
            InitializeComponent();
        }
  
        /// <summary>
        /// Runs the form.
        /// </summary>
        public void Run()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Handles the Generate Checks click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grc_GenerateChecks_Click(object sender, EventArgs e)
        {
            generate_checks_handler();
        }
    }
}
