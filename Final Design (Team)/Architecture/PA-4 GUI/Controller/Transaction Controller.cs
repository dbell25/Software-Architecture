﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public class TransactionController
    {
        private Observer ob;
        private int salesID = 0;
        private string returnval;
        private State status;

        /// <summary>
        /// Creates a new transaction.
        /// </summary>
        /// <param name="transaction"></param>
        public void CreateTransaction(List<Tuple<int, int>> transaction)
        {
            try
            {
                status = State.Transaction;
                List<Tuple<Product, int>> TrueTransaction = new List<Tuple<Product, int>>();

                // error checking
                foreach (Tuple<int, int> T in transaction)
                {
                    if (T.Item1 >= ProductDB.GetProductList().Count || T.Item1 <= 0)
                        throw new Exception("Invalid item ID");
                    else
                        TrueTransaction.Add(new Tuple<Product, int>(ProductDB.GetProduct(T.Item1), T.Item2));
                }
                if (TrueTransaction.Count == 0) throw new Exception();
                salesID++;
                Transaction newTransaction = new Transaction(salesID, TrueTransaction);
                TransactionDB.AddTransaction(newTransaction);
                MessageBox.Show(newTransaction.FormatReceipt());
                returnval = "Transaction generated successfully!";
                update(returnval, status);
            }
            catch (Exception)
            {
                returnval = "\nAn error has occurred. Please try again.";
            }
        }

        /// <summary>
        /// Constructs an Observer.
        /// </summary>
        /// <param name="ob"></param>
        public void RegisterR(Observer ob)
        {
            this.ob = ob;
        }

        /// <summary>
        /// Calls the update method and passes to the OutputForm.
        /// </summary>
        /// <param name="returnval"></param>
        /// <param name="status"></param>
        public void update(string returnval, State status)
        {
            ob(returnval, status);
        }
    }
}