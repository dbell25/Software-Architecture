using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS_501_project_1
{
    public class InputOutputManager
    {
        // Methods:

            // IO Functions for Program State
        /**
         * Get the operation the user wants to perform
         * 
         * Returns:
         *      the int of the process the user wants to perform
         * 
        */
        public void PromptForOperation()
        {
            Console.WriteLine("Are you here to:\n\t1.Create a sales transaction\n\t2.Return an item\n\t3.Enter rebate\n\t4.Generate rebate check\n\t0.Quit");
        }

        public int GetOperation()
        {
            string input = Console.ReadLine();
            int input_value;

            if (Int32.TryParse(input, out input_value ))
                return (Int32.Parse(input));

            // IMPLEMENT DATA CHECKING***********************************************************************************************************************************************************
            throw new Exception("The input was not a valid program function.");

            return (0);
        }



            // IO Functions for Create Sales Transaction
        /** 
         * Get a list of names for the items the user wants to buy
         * 
         * Return:
         *      a list of the names the user is buying
         * 
        */
        public List<string> GetTransactionInput()
        {
            Console.WriteLine("What items would you like to buy: ");

            List<string> item_list = new List<string>();

            string input = "";
            while (true)
            {
                input = Console.ReadLine();

                if (input != "")
                    item_list.Add(input);
                else
                    break;
            }

            return item_list;
        }

        /**
         * Display that the transaction was successful
         * 
        */
        public void DisplaySuccessfulTransaction()
        {
            Console.WriteLine("Your transaction was successful. Thank you for shopping at Sales501.\n");
        }



            // IO Functions for Return Item(s)
        /**
         * Gets the ID of the transaction with an item to return from the user
         * 
         * Returns:
         *      the transaction ID for the transaction with an item to return
         * 
        */
        public string GetReturnTransactionID()
        {
            Console.WriteLine("What is the transaction ID for the transaction with the item you want to return: ");

            return (Console.ReadLine());
        }

        /**
         * Gets the name of the item to return from the user
         * 
         * Return:
         *      string name of the item to return
         * 
        */
        public string GetReturnItemName()
        {
            Console.WriteLine("What item do you want to return: ");

            return (Console.ReadLine());
        }

        /**
         * Display that the refund was successful
         * 
        */
        public void OutputReturnItemSuccessful()
        {
            Console.WriteLine("Your item has been returned. NOTE: this transaction is no longer valid for rebate.\n");
        }



            // IO Functions for Enter Rebate
        /**
         * Get the ID of the transaction to submit for rebate
         * 
         * Returns:
         *      the string of the ID
         * 
        */
        public string GetTransactionIDForRebate()
        {
            Console.WriteLine("What is the ID for the transaction: ");

            return (Console.ReadLine());
        }

        /**
         * Output that the transaction was successful
         * 
        */
        public void OutputRebateTransactionSuccessful()
        {
            Console.WriteLine("Your transaction has successfully been submitted for rebate.\nThank you.\n");
        }



            // MISC METHODS
        /**
         * A replacement for Console.WriteLine since I wanted to run EVERYTHING through the manager
         * 
        */
        public void Display(string s)
        {
            Console.WriteLine(s);
        }

        /**
         * Displays the introduction to the store.
         * 
        */
        public void DisplayIntroduction()
        {
            Console.WriteLine("Welcome to Sales501\n\n");
        }

        /**
         * Displays the goodbye from the store.
         * 
        */
        public void OutputGoodbye()
        {
            Console.WriteLine("Thank you for working with Sales501");
        }
    }
}