using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS_501_project_1
{
    public class Database
    {
        /****
         * 
         * I have left a lot of exceptions here. 
         * I decided to leave them in the code for now because I think that seeing where the function fails at the lowest point is the easiest way to debug.
         * In later iterations, I will probably implement error handling of some kind.
         * 
         ***/
        // Constants:
        


        // Fields:
        private Dictionary<string, Item> dictionary_of_items = new Dictionary<string, Item>(); // all items in the store
        private List<Transaction> list_of_transactions = new List<Transaction>(); // all transactions that have happened in the store
        private List<Transaction> list_of_rebates = new List<Transaction>(); // all transactions that have been submitted for rebate successfully
        private string last_transaction_id = "0000"; // a varible to keep track of transaction ID's
        private Date default_date = new Date(15, "July", 2018); // default date set for all transactions



        // Constructors:
        public Database()
        {
            // populating dictionary of items
            // NOTE: item id 0 is reserved for garbage
            dictionary_of_items.Add("banana", new Item("Banana", 1, 2.00, "Yellow and fruity"));
            dictionary_of_items.Add("coffee", new Item("Coffee", 2, 3.00, "Black and coffee-y"));
            dictionary_of_items.Add("orange", new Item("Orange", 3, 4.00, "Orange and citrus-y"));
            dictionary_of_items.Add("shirt", new Item("Shirt", 4, 5.00, "You wear it."));
        }



        // Methods:
        /**
         * Creates a transaction and adds it to the list_of_transactions
         * 
         * Parameters: 
         *      string_item_list = a list of items that the transaction contains. the strings are names of Items in the database. If the item is not in the store, exception is thrown.
         *      date = the date of the transaction. Through a bit a trickery, if no date is give, a default date is used.
         *      
         * Returns:
         *      a string of the transaction.toString()
         */
        public string CreateTransaction(List<string> string_item_list, Date date = new Date() )
        {
            if (date.Month == null) // if the date is a new date with no data for Month, use the default date
                date = default_date;

            string transaction_id = CreateTransactionId(last_transaction_id);

            Transaction transaction = new Transaction(transaction_id, date);

            foreach(string s in string_item_list )
            {
                if (dictionary_of_items.ContainsKey(s))
                {
                    transaction.AddItem(dictionary_of_items[s]);
                }
                else
                    throw new Exception("Item is not in the database of the items");
            }

            list_of_transactions.Add(transaction);
            return (transaction.ToString());
        }

        /**
         * Converts the name of an item to an Item object
         * 
         * Paramters:
         *      item = the name of the item to be created
         *      
         * Returns:
         *      the Item created. If item was not in database, exception is thrown
         * 
        */
        private Item ConvertStringToItem(string item)
        {
            foreach( KeyValuePair<string, Item> entry in dictionary_of_items)
            {
                if( string.Compare(item, entry.Key.ToString(), true) == 0 ) // NOTE: this comparison is NOT case sensitive
                {
                    return entry.Value;
                }
            }

            throw new Exception("Item is not in the database of items");
        }

        /**
         * Creates a unique tranasction ID for each transaction to be identified by
         * 
         * Parmeters:
         *      last_transaction_id = the string of the last transaction_id created.
         *      
         * Return:
         *      the string of the unique id created
         * 
        */
        private string CreateTransactionId(string last_transaction_id)
        {
            // TransactionId's are 4 digit hexadecimal numbers

            string s = last_transaction_id; // Does this line create a new varible or just reference the same index ********************************************************

            int i = int.Parse(s, System.Globalization.NumberStyles.HexNumber) + 1;

            s = i.ToString("0000");
            this.last_transaction_id = s;

            return s;
        }

        /**
         * Search the database for a transaction
         * 
         * Parameters:
         *      transaction_id = the unique string identifier for the transaction
         *      
         * Return:
         *      the transaction if found. If not, exception is thrown
         * 
        */
        public Transaction GetTransaction(string transaction_id)
        {
            foreach ( Transaction t in list_of_transactions )
            {
                if( t.ID == transaction_id )
                {
                    return t;
                }
            }

            throw new Exception("Transaction ID not in Database. The database could not return the transaction.");
        }

        /**
         * Remove a tranaction for the database
         * 
         * Parameters:
         *      transaction_id = the unique string identifier of the string to be removed.
         *      
         * Returns:
         *      true if successful. throwns an exception if the ID is not in the database.
         * 
        */
        public bool RemoveTransaction(string transaction_id)
        {
            foreach( Transaction t in list_of_transactions )
            {
                if( t.ID == transaction_id )
                {
                    list_of_transactions.Remove(t);
                    return true;
                }
            }

            throw new Exception("Transaction ID was not found in the database. The transaction was not removed.");
            return false;
        }

        /**
         * Submit a transaction's item for item. Note: does not refund the entire transaction.
         * 
         * Parameters:
         *      transaction = the transaction to remove the item from
         *      item_name = the name of the item to remove
         *      
         * Return:
         *      true if successful. false is unsucessful. thrown an exception if 
         * 
        */
        public bool RefundTransaction( Transaction transaction, string item_name)
        {
            Item item = ConvertStringToItem(item_name);

            foreach( Item i in transaction.ItemList )
            {
                if( transaction.ItemList.Contains(item) )
                {
                    transaction.CanBeRefunded = false;
                    transaction.RemoveItem(i);
                    //RemoveTransaction(transaction.ID); // Not sure if I should do this for the assignment or not
                    return true;
                }
            }

            throw new Exception("Transaction ID was not found in the database. The refund was not successful.");
            return false;
        }

        /**
         * Check if a date is inside the valid date range
         * 
         * Parameters: 
         *      date = the date of the transaction
         *      deadline = the date the transaction must be submitted by
         *      
         * Return:
         *      true if date is valid for rebate. false if not.
         * 
        */
        public bool IsValidRebateDate( Date date, Date deadline = new Date() )
        {
            if( deadline.Month == null )
            {
                deadline = default_date;
            }

            throw new Exception("Not implemented yet."); //*******************************************************************************************************************
            return false;
        }

        /**
         * Submit a transaction for rebate
         * 
         * Parameters:
         *      transaction = the transaction to submit for rebate
         *      
         * Return:
         *      true if successful. false if unsuccessful. throw an exception if the transaction is not availible for rebate.
         * 
        */
        public bool SubmitTransactionForRebate(Transaction transaction)
        {
            if(transaction.CanBeRefunded)
            {
                // NEEDS TO INCLUDE A CHECK FOR DATE***************************************************************************************************************************
                list_of_rebates.Add(transaction);
                return true;
            }

            throw new Exception("Transaction can not be submitted for rebate. It is possible an item on the transaction was refunded.");
            return false;
        }

        /**
         * Find the total cost of all transactions for a list of transactions
         * 
         * Parameters:
         *      list_of_transactions = a list of the transactions to iterate through
         *      
         * Returns:
         *      a double containing the sum of the transactions
         * 
        */
        public double TotalCostOfTransactions(List<Transaction> list_of_transactions)
        {
            double sum = 0;
            foreach(Transaction t in list_of_transactions)
            {
                sum += t.Cost;
            }

            return sum;
        }

        /**
         * Generates a string for the Rebate Check
         * 
         * Returns:
         *      a string of the rebate check
         * 
        */
        public string GenerateRebateCheck()
        {
            String s = "Total number of transactions: " + list_of_transactions.Count +
                "\nTotal number of rebates: " + list_of_rebates.Count +
                "\nTotal cost of all transactions: " + TotalCostOfTransactions(list_of_transactions).ToString(".00") +
                "\nTotal cost of all rebates: " + (.11 * TotalCostOfTransactions(list_of_rebates)).ToString(".00");

            return s;
        }
    }
}