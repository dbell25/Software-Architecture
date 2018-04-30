using System;
using System.Collections.Generic;

namespace PA_4_GUI
{
    public class ReturnController
    {
        private Observer ob;
        private string returnval = "";
        private State status;

        /// <summary>
        /// Processes a return request given a receipt.
        /// </summary>
        /// <param name="receiptID"></param>
        /// <param name="itemID"></param>
        /// <param name="itemAmount"></param>
        public void ProcessReturn(int receiptID, int itemID, int itemAmount)
        {
            status = State.Return;
            if (receiptID > TransactionDB.GetTransactionInt() || receiptID < 0) throw new Exception();
            Transaction receipt = TransactionDB.GetTransaction(receiptID);
            
            for (int i = 0; i < receipt.GetItems.Count; i++)
            {
                List<Tuple<Product, int>> temp = receipt.GetItems;
                if (temp[i].Item1.ID == itemID)
                {
                    if (itemAmount > temp[i].Item2)
                    {
                        returnval = "Error. Cannot return more items than purchased.";
                        update(returnval, status);
                        return;
                    }   
                    else
                    {
                        temp[i] = new Tuple<Product, int>(temp[i].Item1, temp[i].Item2 - itemAmount);
                        returnval = "Success! Items returned.";
                        update(returnval, status);
                        return;
                    } 
                }
            }
            returnval = "Error. Item Not Found.";
            update(returnval, status);
        }

        /// <summary>
        /// Constructs an Obeserver.
        /// </summary>
        /// <param name="ob"></param>
        public void RegisterR(Observer ob)
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