namespace PA_4_GUI
{
    /// <summary>
    /// Processes requests for generating submitted rebate checks
    /// </summary>
    public class GenerateChecksController
    {
        private Observer ob;
        private string returnval = "No checks to generate.";
        private State status;

        /// <summary>
        /// Generates the rebate checks.
        /// </summary>
        /// <param name="percent">percentage of the discount</param>
        /// <param name="Date">date of rebate submission</param>
        /// <returns></returns>
        public void GenerateChecks() // may want to hard code the rebate percent;
        {
            status = State.Generate;
            returnval = RebateDB.GenerateRebateChecks();
            update(returnval, status);
        }

        /// <summary>
        /// Constructs an Observer.
        /// </summary>
        /// <param name="ob"></param>
        public void RegisterGCC(Observer ob)
        {
            this.ob = ob;
        }

        /// <summary>
        /// Calls the update method and passes to the OutputForm
        /// </summary>
        /// <param name="returnval"></param>
        /// <param name="status"></param>
        public void update(string returnval, State status)
        {
            ob(returnval, status);
        }
    }
}

