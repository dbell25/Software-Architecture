using System;
using System.Collections.Generic;

namespace PA_4_Console
{
    // delegate prototypes;
    public delegate void ICreateTransaction(List<Tuple<int, int>> transaction);
    public delegate void IProcessReturn(int ID, int itemNum, int itemAmount);
    public delegate void ISubmitRebate(DateTime date, int ID);
    public delegate void IGenerateRebate();

    /// <summary>
    /// Input form for processing user requests.
    /// </summary>
    public class InputForm
    {
        // delegate declarations
        private ICreateTransaction transaction_handler;
        private IProcessReturn return_handler;
        private ISubmitRebate rebate_handler;
        private IGenerateRebate generate_checks_handler;
        private State status = new State();

        /// <summary>
        /// Constructs a new input form.
        /// </summary>
        /// <param name="rebh"></param>
        public InputForm(ICreateTransaction th, ISubmitRebate rebh, IProcessReturn reth, IGenerateRebate gch)
        {
            transaction_handler = th;
            rebate_handler = rebh;
            generate_checks_handler = gch;
            return_handler = reth;
        }

        /// <summary>
        /// Prints the main selection menu. 
        /// </summary>
        public void Menu()
        {
            try
            {
                status = State.Default;
                Console.Write("\nWelcome to Sales 501!\n 1.) Rebate\n 2.) Return\n 3.) Transaction\n 4.) Generate Checks\n 5.) Exit\nWhat would you like to do?: ");
                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans > 5 || ans < 0) throw new Exception();
                switch (ans)
                {
                    case 1: AddToRebateList(); break;
                    case 2: ProcessReturn(); break;
                    case 3: CreateTransaction(); break;
                    case 4: GenerateChecks(); break;
                    case 5: Environment.Exit(0); break;
                    default: throw new Exception();
                }
            }
            catch (Exception)
            {
                status = State.Default;
                Console.WriteLine("\nInvalid Entry. Please try again.\n");
                Menu();
            }
        }

        /// <summary>
        /// Prompts the user for transaction data.
        /// Passes transaction data to the Transaction Controller
        /// </summary>
        /// <param name="transaction">list of items purchased by the customer</param>
        public void CreateTransaction()
        {
            try
            {
                status = State.Transaction;
                bool add_item = true;
                List<Product> items_available = ProductDB.GetProductList();
                List<Tuple<int, int>> transaction_items = new List<Tuple<int, int>>();

                Console.WriteLine("\nID:\tName:\t\tPrice:");
                for (int i = 0; i < items_available.Count; i++)
                {
                    Console.Write(items_available[i].ID + "\t" + items_available[i].GetName);
                    if (items_available[i].GetName.Length > 7) Console.Write("\t");
                    else Console.Write("\t\t");
                    Console.WriteLine("$" + items_available[i].GetPrice);
                }

                while (add_item)
                {
                    int itemID, itemQuantity;
                    string answer = "N";

                    Console.Write("\nWhat would you like to purchase?: ");
                    itemID = Convert.ToInt32(Console.ReadLine());
                    if (itemID < 1 || itemID > 16)
                    {
                        Console.WriteLine("Invalid Entry!! Try again.");
                        continue;
                    }
                    else
                    {
                        Console.Write("How many would you like to purchase?: ");
                        itemQuantity = Convert.ToInt32(Console.ReadLine());
                        if (itemQuantity < 1 || itemQuantity > 20)
                        {
                            Console.WriteLine("Invalid amount. Please choose between 1 and 20.");
                            continue;
                        }
                        else
                        {
                            Tuple<int, int> tempTup = new Tuple<int, int>(itemID, itemQuantity);
                            transaction_items.Add(tempTup);
                        }
                    }

                    Console.Write("Would you like to add another product? (Y/N): ");
                    answer = Console.ReadLine().ToUpper();
                    if (answer == "Y") add_item = true;
                    else if (answer == "N") add_item = false;
                    else
                    {
                        Console.WriteLine("Invalid input. Start over.\n");
                        status = State.Default;
                        add_item = false;
                    }
                }
                transaction_handler(transaction_items);
            }
            catch(Exception)
            {
                Console.WriteLine("\nInvalid Entry. Please try again.\n");
            }
            Menu();
        }

        /// <summary>
        /// Prompts the user for rebate data.
        /// Passes rebate data to the Rebate Controller.
        /// </summary>
        /// <param name="date">final date the discount is valid</param>
        /// <param name="percentage">percentage of discount</param>
        /// <param name="ID">item ID the discount is valid for</param>
        public void AddToRebateList()
        {
            try
            {
                status = State.Rebate;
                int receipt_num;
                Console.Write("Please enter your receipt number: ");
                receipt_num = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is today's month? ie /mm/: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is today's day? ie /dd/: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is today's year? ie /yyyy/: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime cutOffDate = new DateTime(year, month, day);
                rebate_handler(cutOffDate, receipt_num);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Entry. Please Try Again.");
            }
            Menu();
        }

        /// <summary>
        /// Prompts the user for return data.
        /// Passes a return request to the Return Controller.
        /// </summary>
        /// <param name="ID">item ID of the item to be returned</param>
        /// <param name="returnval">the receipt itself</param>
        public void ProcessReturn()
	    {
            try
            {
                status = State.Return;
                int itemNum = 0, itemAmount = 0, receipt_num = 0;
                bool cont = true;

                Console.Write("Please enter in your receipt number: ");
                receipt_num = Convert.ToInt32(Console.ReadLine());
                Transaction items = TransactionDB.GetTransaction(receipt_num);
                Console.WriteLine(items.FormatReceipt() + "\n");

                while (cont)
                {
                    Console.Write("What item number would you like to return?: ");
                    itemNum = Convert.ToInt32(Console.ReadLine());
                    Console.Write("How many would you like to return?: ");
                    itemAmount = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Would you like to continue returning more items? (Y/N): ");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        cont = true;
                    }
                    else if(answer == "N")
                    {
                        cont = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Start over.\n");
                        status = State.Default;
                        cont = false;
                    }
                }
                return_handler(receipt_num, itemNum, itemAmount);
            }
            catch
            {
                Console.WriteLine("\nInvalid Entry. Please try again.\n");
            }
            Menu();
	    }

        /// <summary>
        /// Passes the submitted rebate requests to the GenerateChecksController.
        /// </summary>
	    public void GenerateChecks()
	    {
            status = State.Generate;
            generate_checks_handler();
            Menu();
	    }
    }
}
