using System.Collections.Generic;

namespace PA_4_GUI
{
    public static class TransactionDB
    {
        private static List<Transaction> Transactions = new List<Transaction>();
        
        /// <summary>
        /// Adds Transactions to the database.
        /// </summary>
        /// <param name="T"></param>
        public static void AddTransaction(Transaction T)
        {
            Transactions.Add(T);
        }
        
        /// <summary>
        /// Returns a transaction given a receipt number.
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static Transaction GetTransaction(int ID)
        {
            return Transactions[ID-1];
        }

        /// <summary>
        /// Returns the number of transactions.
        /// </summary>
        /// <returns></returns>
        public static int GetTransactionInt()
        {
            return Transactions.Count;
        }
    }
}
