//Ashley Morton
//Project One
//Project will allow user to make purchases, stores the receipts, 
//then allows the user to see rebate check if the receipt is valid and
//is within a specified time period between june 1 and july 31.
//One small error but the rebate check is still calculated and shown on screen.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MortonA_PA1
{
    class Program
    {


        static void Main(string[] args)
        {

            //dictionary for checks that are invalid for rebate
            //Dictionary<int, bool> InvalidChecks = new Dictionary<int, bool>();
            //dictionary for adding items to the receipt
            Dictionary<string, double> Receipt = new Dictionary<string, double>();
            //dictionary for created receipts
            Dictionary<int, Dictionary<string, double>> ValidChecks = new Dictionary<int, Dictionary<string, double>>();
            string choice;
            double total = 0;
            string enterMatrix = "yes";
            //Keeps count of checks to assign check numbers
            int count = 0;
            try
            {
                while (enterMatrix == "yes")
                {
                Console.WriteLine("Would you like to make a (P)urchase, (R)eturn or re(B)ate? ");
                choice = Console.ReadLine().ToUpper();
                int loop = 0;
                string itemChoice;
                double itemPrice;
                int recNum;
                string itemReturn;
                int itemQuantReturn;
                    int date;

                
                    while (loop == 0)
                    {
                        if (choice == "P")
                        {

                            int enter = 0;

                            while (enter == 0)
                            {
                                string c2;
                                Console.WriteLine("What would you like to purchase?");
                                itemChoice = Console.ReadLine();
                                Console.WriteLine("What is the price?");
                                itemPrice = Convert.ToDouble(Console.ReadLine());
                                Receipt.Add(itemChoice, itemPrice);
                                Console.WriteLine("Do you wish to enter another item? (Y)es or (N)o");
                                c2 = Console.ReadLine().ToUpper();

                                if (c2 == "Y")
                                {
                                    c2 = "";

                                    continue;
                                }
                                else if (c2 == "N")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid entry");
                                }
                                c2 = "";
                            }//End while loop
                            count++;

                            Console.WriteLine("Receipt Number: " + count);
                            choice = "";
                            break;
                        }//end if p
                        else if (choice == "R")
                        {
                            Console.WriteLine("Please enter receipt number: ");
                            recNum = Convert.ToInt32(Console.ReadLine());
                            if (!(ValidChecks.ContainsKey(recNum)))
                            {
                                Console.WriteLine("Invalid Receipt Number");
                                break;
                            }//End if not in dictionary
                            else
                            {
                                //Display receipt so user knows what it contains

                                //Ask user which item they would like to return
                                Console.WriteLine("Which Item would you like to return?: ");
                                itemReturn = Console.ReadLine();

                                //Ask quantity of item being returned
                                Console.WriteLine("How many do you need to return?: ");
                                itemQuantReturn = Convert.ToInt32(Console.ReadLine());
                                //call return

                            }//end else in dictionary
                            choice = "";
                            break;
                        }//end if r
                        else if (choice == "B")
                        {
                            double tempTotal = 0;
                            Dictionary<string, double> temp = new Dictionary<string, double>();
                            Console.WriteLine("Please enter receipt number: ");
                            recNum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter date of receipt (monthday): i.e: 0216");
                            date = Convert.ToInt32(Console.ReadLine());
                            if (!ValidChecks.ContainsKey(recNum))
                                return;
                            else
                            {
                                if (date > 0731 || date < 0601)
                                {
                                    Console.WriteLine("Invalid");
                                    return;
                                }
                                else
                                {
                                    temp = ValidChecks[recNum];
                                    foreach (KeyValuePair<string, double> c in temp)
                                    {
                                        tempTotal += c.Value;
                                    }
                                    double rebate = tempTotal * .11;

                                    Console.WriteLine("Your rebate is: ${0}\n", rebate);
                                }
                            }
                            choice = "";
                            break;
                        }//end if b
                        else
                        {
                            Console.WriteLine("Invalid choice...");
                            Console.WriteLine("Would you like to make a (P)urchase, (R)eturn or re(B)ate? ");
                            choice = Console.ReadLine().ToUpper();
                            loop = 0;
                            choice = "";
                            break;
                        }
                    }//End while

                    //Test print dictionary receipt
                    foreach (KeyValuePair<string, double> a in Receipt)
                    {
                        Console.WriteLine("item = {0}, price = {1}", a.Key, a.Value);
                    }
                    //get check total
                    foreach (KeyValuePair<string, double> b in Receipt)
                    {
                        total += b.Value;
                    }
                    Console.WriteLine("Check Total : ${0} \n", total);

                    ValidChecks.Add(count, Receipt);

                    total = 0;
                    Console.WriteLine("Are you done? Yes to exit or No to enter another purchase, rebate, or return: ");
                    enterMatrix = Console.ReadLine().ToUpper();
                    if (enterMatrix == "N" || enterMatrix == "NO")
                        enterMatrix = "yes";
                    else
                    {
                        enterMatrix = "No";
                    }

                }//end whole while
        }//End try
                catch(ArgumentNullException)
                {

                }//End catch
        }//end main

        
    }//end class
}
