using System;
using System.Collections.Generic;
using System.Text;

namespace PA_4_GUI
{
    public class Transaction
    {
        private DateTime Transdate;
        private List<Tuple<Product, int>> items;
        private int sales_ID;

        /// <summary>
        /// Constructs a new Transaction object.
        /// </summary>
        /// <param name="sales_ID"></param>
        /// <param name="items"></param>
        public Transaction(int sales_ID, List<Tuple<Product, int>> items)
        {
            this.sales_ID = sales_ID;
            this.items = items;
        }

        /// <summary>
        /// Calculates the total of a Transaction.
        /// </summary>
        /// <returns></returns>
        private double GetTotal()
        {
            double total = 0;
            foreach (Tuple<Product, int> t in items)
            {
                total += (t.Item1.GetPrice) * (t.Item2);
            }
            return total;
        }

        /// <summary>
        /// Calculates the amount that needs to be refunded from a rebate.
        /// </summary>
        /// <param name="percent"></param>
        /// <returns></returns>
        public string IncludeRebate(double percent)
        {
            double total = GetTotal();
            total *= percent;
            return ("Sales Number:" + sales_ID + "\nRebate Total: $" + total + "\n");
        }

        /// <summary>
        /// Formats a receipt.
        /// </summary>
        /// <returns></returns>
        public string FormatReceipt()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Customer Copy\n" + Transdate + "\n"
                + "------------------------\n" + "Sale Number: " 
                    + sales_ID + "\n------------------------\n" + "\n");
            foreach (Tuple<Product, int> T in items)
            {
                sb.Append(T.Item1.GetName + ": $" + (T.Item1.GetPrice * T.Item2) + "\n" + "Item Number: " 
                    + T.Item1.ID + "\n" + "Quantity: " + T.Item2 + " @ $" + T.Item1.GetPrice + "each.\n------------------------\n");
            }
            sb.Append("\nTotal: $" + GetTotal());
            return sb.ToString();
        }

        /// <summary>
        /// Returns the date of a given Transaction.
        /// </summary>
        public DateTime GetTD
        {
            get
            {
                return Transdate;
            }
        }
        
        /// <summary>
        /// Returns the items of a given transaction.
        /// </summary>
        public List<Tuple<Product, int>> GetItems
        {
            get
            {
                return items;
            }
        }
    }
}