using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace PA_4_GUI
{
    // delegate prototypes;
    public delegate void ICreateTransaction(List<Tuple<int, int>> transaction);
    public delegate void IProcessReturn(int ID, int itemNum, int itemAmount);
    public delegate void ISubmitRebate(DateTime date, int ID);
    public delegate void IGenerateRebate();

    public partial class uxMainMenu : Form
    {
        private State status = new State();
        private ICreateTransaction transaction_handler;
        private IProcessReturn return_handler;
        private ISubmitRebate rebate_handler;
        public IGenerateRebate generate_checks_handler;

        /// <summary>
        /// Initializes the MainMenu class.
        /// </summary>
        public uxMainMenu(ICreateTransaction th, ISubmitRebate rebh, IProcessReturn reth, IGenerateRebate gch)
        {
            InitializeComponent();
            transaction_handler = th;
            rebate_handler = rebh;
            generate_checks_handler = gch;
            return_handler = reth;
        }

        /// <summary>
        /// Handles the uxCreateTransaction button click.
        /// Creates and shows a new CreateTransaction form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateTransaction_Click(object sender, EventArgs e)
        {
            status = State.Transaction;
            uxCreateTransaction transaction_form = new uxCreateTransaction(transaction_handler);
            Thread transaction_thread = new Thread(new ThreadStart(transaction_form.Run));
            transaction_thread.Start();
        }

        /// <summary>
        /// Handles the uxProcessReturn button click.
        /// Creates and shows a new uxProcessReturn form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxProcessReturn_Click(object sender, EventArgs e)
        {
            status = State.Return;
            uxProcessReturn return_form = new uxProcessReturn(return_handler);
            Thread return_thread = new Thread(new ThreadStart(return_form.Run));
            return_thread.Start();
        }

        /// <summary>
        /// Handles the uxCreateRebate button click.
        /// Creates and shows a new uxCreateRebatet form.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCreateRebate_Click(object sender, EventArgs e)
        {
            status = State.Rebate;
            uxCreateRebate rebate_form = new uxCreateRebate(rebate_handler);
            Thread rebate_thread = new Thread(new ThreadStart(rebate_form.Run));
            rebate_thread.Start();
        }

        /// <summary>
        /// Handles the uxGenerateChecks button click.
        /// Creates and shows a new uxGenerateChecks form.
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxGenerateChecks_Click(object sender, EventArgs e)
        {
            status = State.Generate;
            uxGenerateChecks generate_checks_form = new uxGenerateChecks(generate_checks_handler);
            Thread generate_thread = new Thread(new ThreadStart(generate_checks_form.Run));
            generate_thread.Start();
        }

        /// <summary>
        /// Runs the form.
        /// </summary>
        public void Run()
        {
            status = State.Default;
            Application.Run(this);
        }
    }
}
