﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class UserInterface
    {
        
        static void Main(string[] args)
        {
            ReceiptDataBase RDB = new ReceiptDataBase();
            int receiptnum = 0;
            bool quit = false;
            while (!quit)
            {
                int reply = 0;
                Boolean result = false;
                Console.WriteLine("1. Make a Transaction With no returns.\n" + "2. Make one sales transaction with at least one item returned.\n" + "3. Send in Rebate.\n" + "4. Generate 1 or more rebate checks.\n" + "Enter number of the event you want to exicute(enter just the int(i.e.'1','2'...)): ");
                result = Int32.TryParse(Console.ReadLine(), out reply);
                if (result)
                {
                    switch (reply)
                    {
                        case 1:
                            {
                                RDB.addReceipt(Transaction(receiptnum));
                                receiptnum++;
                                break;
                            }
                        case 2:
                            {

                                break;
                            }
                        case 3:
                            {
                                break;
                            }
                        case 4:
                            {
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Non valid input");
                }
                bool repeat2 = true;
                while (repeat2)
                {
                    Console.WriteLine("Would you quit program (enter 'y' or 'n'): ");
                    char[] yn = (Console.ReadLine().ToUpper()).ToCharArray();
                    switch (yn[0])
                    {
                        case 'Y':
                            {
                                quit = true;
                                repeat2 = false;
                                break;
                            }
                        case 'N':
                            {
                                quit = false;
                                repeat2 = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Non valid input\n");
                                break;
                            }
                    }
                }
            }


        }

        private static Receipt Transaction(int receiptNumber)
        {
            bool repeat = true;
            ItemDatabase idb = new ItemDatabase();
            Console.WriteLine("Enter Name of custumer:");
            string name = Console.ReadLine();
            while (repeat == true)
            {
                int item = -1;
                int numbOf = 0;

                Boolean iResult = false;
                Console.WriteLine("List of the items you can buy:\n1.25ft. extention cord - $9.47\n2.50ft. extention cord - $10.97\n3.100ft. extention cord - $19.97\n4.60 Watt LED Light Bulb(8-Pack)- $13.28\n5.60-Watt Equivalent Spiral CFL Light Bulb, Soft White (4-Pack)- $5.97\n" +
                    "6.Febreze Air Effects Hawaiian Aloha Air Freshener - 8.8oz / 2ct - $4.99\n7.Febreze Air Effects Linen & Sky Scent, 8.8 oz, 2 pk- $4.99\n8.Febreze Air Effects Gain Original Scent, 8.8 oz, 2 pk- $4.99\nEnter the number of the Item you want:");
                iResult = Int32.TryParse(Console.ReadLine(), out item);
                if (iResult)
                {

                    Console.WriteLine("Enter a positive integer representing how many of this product you want: ");
                    iResult = Int32.TryParse(Console.ReadLine(), out numbOf);
                    idb.buying[item].add(numbOf);
                }
                else
                {
                    Console.WriteLine("Non valid input\n");
                }
                numbOf = 2;
                bool repeat2 = true;
                while (repeat2)
                {
                    Console.WriteLine("Would you like to add more items(enter 'y' or 'n'): ");
                    char[] yn = (Console.ReadLine().ToUpper()).ToCharArray();
                    switch (yn[0])
                    {
                        case 'Y':
                            {
                                repeat2 = false;
                                break;
                            }
                        case 'N':
                            {
                                
                                Console.WriteLine(idb.BuyingToString());
                                return new Receipt(name, receiptNumber, idb.buying);
                               // repeat = false;
                               // repeat2 = false;
                                //break;
                            }
                        default:
                            {
                                throw new IOException("non valid input\n");
                                  //  Console.WriteLine("Non valid input\n");
                               // break;
                            }
                    }
                }


            }
            return null;
        }

        private static void ItemReturn()
        {
            bool repeat = true;
            ItemDatabase idb = new ItemDatabase();
            while (repeat == true)
            {
                int item = -1;
                int numbOf = 0;

                Boolean iResult = false;
                Console.WriteLine("List of the items you can return:\n1.25ft. extention cord - $9.47\n2.50ft. extention cord - $10.97\n3.100ft. extention cord - $19.97\n4.60 Watt LED Light Bulb(8-Pack)- $13.28\n5.60-Watt Equivalent Spiral CFL Light Bulb, Soft White (4-Pack)- $5.97\n" +
                    "6.Febreze Air Effects Hawaiian Aloha Air Freshener - 8.8oz / 2ct - $4.99\n7.Febreze Air Effects Linen & Sky Scent, 8.8 oz, 2 pk- $4.99\n8.Febreze Air Effects Gain Original Scent, 8.8 oz, 2 pk- $4.99\nEnter the number of the Item you want to return:");
                iResult = Int32.TryParse(Console.ReadLine(), out item);
                if (iResult)
                {

                    Console.WriteLine("Enter a positive integer representing how many of this product you want to return: ");
                    iResult = Int32.TryParse(Console.ReadLine(), out numbOf);
                    idb.buying[item].remove(numbOf);
                }
                else
                {
                    Console.WriteLine("Non valid input\n");
                }
                numbOf = 2;
                bool repeat2 = true;
                while (repeat2)
                {
                    Console.WriteLine("Would you like to Return more items(enter 'y' or 'n'): ");
                    char[] yn = (Console.ReadLine().ToUpper()).ToCharArray();
                    switch (yn[0])
                    {
                        case 'Y':
                            {
                                repeat2 = false;
                                break;
                            }
                        case 'N':
                            {
                                Console.WriteLine(idb.BuyingToString());
                                repeat = false;
                                repeat2 = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Non valid input\n");
                                break;
                            }
                    }
                }


            }
        }
        private static void EnterRebate()
        {

        }
        private static void GenerateRebateCheck()
        {

        }

    }
}
