using System;
using System.Collections.Generic;

namespace PA_4_Console
{
    public static class TransactionDB
    {
        private static List<Transaction> Transactions = new List<Transaction>();
        
        /// <summary>
        /// Adds a Transaction to the database.
        /// </summary>
        /// <param name="T"></param>
        public static void AddTransaction(Transaction T)
        {
            Transactions.Add(T);
        }
        
        /// <summary>
        /// Returns a Transaction given a receipt number.
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
