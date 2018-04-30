using System;

namespace PA_4_GUI
{
    public class RebateController
    {
        private Observer ob;
        private string returnval;
        private State status;

        /// <summary>
        /// Adds a Transaction to the Rebate DataBase.
        /// </summary>
        /// <param name="Date"></param>
        /// <param name="ID"></param>
        public void AddToRebateList(DateTime Date, int ID)
        {
            status = State.Rebate;
            Transaction temp = TransactionDB.GetTransaction(ID);
            returnval = RebateDB.AddRebateToList(temp, Date);
            update(returnval, status);
        }

        /// <summary>
        /// Constructs an Observer.
        /// </summary>
        /// <param name="ob"></param>
        public void RegisterRC(Observer ob)
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


