/* Author: Michael Yangmi
 * Professor: Jorge Valenzuela
 * CIS 501
 * PA-1
 * Sales501.cs
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1
{
    class Sales501
    {
        //Dictionary that tracks what the customer has purchased.
        public static Dictionary<string, SalesItem> customerCart = new Dictionary<string, SalesItem>(); //Holds the items the customer has decided to purchase
        public static Dictionary<int, Dictionary<string, SalesItem>> orderHistory = new Dictionary<int, Dictionary<string, SalesItem>>(); //Contains the history of orders and the items purchased
        public static Dictionary<int, string> orderDate = new Dictionary<int, string>(); //Holds sales numbers and the order dates associated with those sales.
        public static List<Rebate> rebateList = new List<Rebate>(); //Holds all the valid rebates created by the user
        public static int salesNumber = 999; //Sales number that will be incremented and distributed to the user each time the user makes a purchase
        public static Dictionary<int, bool> rebateHistory = new Dictionary<int, bool>(); //Checks where a rebate has been generated for the associate sales number

        /// <summary>
        /// Behaves as a main menu for the user that will loop infininately
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            while (true) //Looping Menu for the user.
            {
                Console.WriteLine("\n\nWelcome to Sales501 Menu!");
            
                Console.WriteLine("Please press the corresponding letter for that action you wish to take.\n");
                Console.WriteLine("(P)urchase Items");
                Console.WriteLine("(R)eturn Items");
                Console.WriteLine("(E)nter Rebate");
                Console.WriteLine("(G)enerate Rebate Check");
                

                string response = Console.ReadLine();



                switch (response.ToLower()) //Switch case that will execute based on the user's input
                {
                    case "p":
                        salesNumber++;
                        string purchaseDate = PurchaseItems();
                        if(customerCart.Keys.Count != 0) { //if the customer doesn't buy anything the user won't be check out
                            Checkout();
                            orderDate.Add(salesNumber, purchaseDate);
                            orderHistory.Add(salesNumber, new Dictionary<string, SalesItem>(customerCart));
                        }
                        
                        customerCart.Clear();
                        break;
                    case "r":
                        ReturnItems();
                        break;
                    case "e":
                        if (Rebate.IsRebateValid())
                        {
                            Console.WriteLine("\nYour Rebate has been created!");
                        }
                        else
                        {
                            Console.WriteLine("\nYour Rebate is not valid!");
                        }
                        break;
                    case "g":
                        Rebate.GenerateRebate();
                        rebateList.Clear();
                        break;
                    default:
                        Console.WriteLine("\nERROR: Please enter a valid choice\nRestarting...");
                        break;
                } //end Switch(response.ToLower())
            } //end While(true)
        } //end Main()



        /// <summary>
        /// Uses the customerReturnCart dictionary and the predefined dictionary in the SalesItem class in order to keep track of what the customer has decided to return and the given costs of those products
        /// </summary>
        private static void ReturnItems()
        {
            Console.WriteLine("Enter the Sales number for your return: ");
            int salesNum = Convert.ToInt32(Console.ReadLine());
            double grandTotal = 0;
            foreach(string key in orderHistory[salesNum].Keys)
            {
                grandTotal += orderHistory[salesNum][key].ItemCostTotal;
            }

            if (rebateHistory.ContainsKey(salesNum) && rebateHistory[salesNum])
            {
                Console.WriteLine("ERROR: YOU CANNOT RETURN ITEMS AFTER THE REBATE HAS BEEN GENERATED");
                return;
            }

            if (!orderHistory.ContainsKey(salesNum))
            {
                Console.WriteLine("\nError: sales number does not exist! Returning to Menu...");
                return;
            }

            Console.WriteLine();
            foreach(string key in orderHistory[salesNum].Keys)
            {
                Console.WriteLine(orderHistory[salesNum][key].ToString());
            }
     
            Console.WriteLine("Which item would you like to return: ");
            string response = "";

            while (response != "n")
            {
                Console.WriteLine("\nPress \"n\" to exit  or  \"reprint\" to reprint the inventory otherwise... \nEnter the name of the item you would like to return: ");
                response = Console.ReadLine().ToLower();

                if (orderHistory[salesNum].ContainsKey(response))
                {
                    Console.Write("How many would you Like to return? : ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    if(num > orderHistory[salesNum][response].ItemCount)
                    {
                        Console.WriteLine("ERROR: YOU CANNOT RETURN MORE ITEMS THAT YOU PURCHASED\nRETURNING TO MENU...");
                        return;
                    }
                    if (num < 1)
                    {
                        Console.WriteLine("ERROR: YOU CANNOT RETURN LESS THAN ONE ITEMS\nRETURNING TO MENU...");
                        return;
                    }
                    orderHistory[salesNum][response].ItemCount = (orderHistory[salesNum][response].ItemCount - num);
                    orderHistory[salesNum][response].ItemCostTotal = (orderHistory[salesNum][response].ItemCount * SalesItem.storeInventoryList[response].ItemCost);

                } // end else if
                else if (response == "n")
                {
                    foreach (string key in orderHistory[salesNum].Keys)
                    {
                        grandTotal = grandTotal - orderHistory[salesNum][key].ItemCostTotal;
                    }
                    Console.WriteLine("Your return value is: $" + grandTotal.ToString("f2"));
                    return;
                }
                else if (response == "reprint") //If the UI gets cluttered this will allow the UI 
                {
                    Console.WriteLine();
                    foreach(string key in orderHistory[salesNum].Keys)
                    {
                        Console.WriteLine(orderHistory[salesNum][key].ToString());
                    }
                }
                else if (!SalesItem.storeInventoryList.ContainsKey(response))
                {
                    Console.WriteLine("\n\n\nERROR: Please enter a valid item below...");
                    foreach (string key in orderHistory[salesNum].Keys)
                    {
                        Console.WriteLine(orderHistory[salesNum][key].ToString());
                    }
                }

            }// end while (response != "n")
        } // end ReturnItems


        /// <summary>
        /// Uses the customerCart dictionary and the predefined dictionary in the SalesItem class in order to keep track of what the customer has decided to purchase and the given costs of those products
        /// </summary>
        private static string PurchaseItems()
        {
            string inputDate = "06/01/2018";
            Console.WriteLine("\nThe default date is \"06/01/2018\" would you like to change it? (y/n)");
            string ans = Console.ReadLine();
            while (ans.ToLower() != "y" && ans.ToLower() != "n")
            {
                Console.WriteLine("Please enter a valid choice (y/n)");
                ans = Console.ReadLine();
            }
            if (ans.ToLower() == "y")
            {
                Console.WriteLine("Please Enter the Date: (\"MM/DD/YYYY\")"); //Prompts user for the current date
                inputDate = Console.ReadLine();
                string[] date = inputDate.Split('/');
            }


            Console.WriteLine(SalesItem.PrintStoreInventory()); //Prints the inventory of the store are the given time. This is predetermined in the SalesItem class
            string response = "";



            //Keeps allowing the user to purchase items until they exit using "n"
            while(response != "n")
            {
                Console.WriteLine("\nPress \"n\" to exit  or \"reprint\" to reprint the inventory otherwise...  \nEnter the name of the item you would like to purchase: ");
                response = Console.ReadLine().ToLower();
                
                if(SalesItem.storeInventoryList.ContainsKey(response) && customerCart.ContainsKey(response)) //If the user has purchased a duplicate item it allows them to add to the order
                {
                    Console.WriteLine("You have already purchased " + customerCart[response.ToLower()].ItemName + ". Would you like to purchase more? (y/n)");
                    string r = Console.ReadLine().ToLower();

                    if (r == "y")
                    {
                        Console.WriteLine("Enter the amount you would like to add (0 - X): ");
                        double num = Convert.ToDouble(Console.ReadLine()) + customerCart[response].ItemCount;
                        customerCart[response.ToLower()] = new SalesItem(response, SalesItem.storeInventoryList[response].ItemCost, num);

                    }


                    while (r!= "n" && r!= "y") //Ensures a valid option is chosen by the user
                    {
                         Console.WriteLine("Please Enter a valid choice (y/n)");
                         r = Console.ReadLine().ToLower();
                         if (r == "y")
                         {
                            Console.WriteLine("Enter the amount you would like to add (0 - X): ");
                            double num = Convert.ToDouble(Console.ReadLine()) + customerCart[response].ItemCount;
                            customerCart[response] = new SalesItem(response, SalesItem.storeInventoryList[response].ItemCost, num);
                          
                            }
                        if(r == "n") // breaks out if the user decides they don't want to add to the order.
                        {
                            break;
                        }
                    } // end while (r!= "n" && r!= "y")

                }// end if
                else if (SalesItem.storeInventoryList.ContainsKey(response))
                {
                    Console.Write("How many would you Like to buy? : ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    customerCart.Add(response, new SalesItem(response, SalesItem.storeInventoryList[response].ItemCost, num));
                } // end else if
                else if (response == "n")
                {
                    return inputDate;
                }
                else if (response == "reprint") //If the UI gets cluttered this will allow the UI 
                {
                    Console.WriteLine(SalesItem.PrintStoreInventory());
                }
                else if (!SalesItem.storeInventoryList.ContainsKey(response))
                {
                    Console.WriteLine("\n\n\nERROR: Please enter a valid item below...");
                    Console.WriteLine(SalesItem.PrintStoreInventory());
                }
                
            } // end while
            return inputDate;
        } // end PurchaseItems()


        /// <summary>
        /// Prints the receipt to the user and tells them their grand total
        /// </summary>
        private static void Checkout()
        {
            double grandTotal = 0;
            Console.WriteLine("\n\nYour Receipt:");
            if(customerCart != null)
            {
                Console.WriteLine("\n\nItems Purchased: \n");
                foreach(KeyValuePair<string, SalesItem> k in customerCart)
                {
                    Console.WriteLine(k.Value.ItemName + " X " + k.Value.ItemCount + "  : $" + (k.Value.ItemCost * k.Value.ItemCount).ToString("f2"));
                    grandTotal += (k.Value.ItemCost * k.Value.ItemCount);
                }
                Console.WriteLine("\n\nYour Grand Total is: $" + grandTotal.ToString("f2") + "\nYour Sales #: " + salesNumber);
            }
        } //End Checkout()




    } //end class
} //end namespace
