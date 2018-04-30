using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    public class Sales
    {
        // stores the current rebate.
        private Promotion _rebate;

        // Stores all completed purchases.
        private List<Transaction> _purchases;

        // Stores the items rebated based on receipt number and item name.
        private List<int> _discounted;

        // Constructs a new Sales object.
        public Sales()
        {
            _purchases = new List<Transaction>();
            _discounted = new List<int>();
        }
   
        // Runs the main menu interface and returns the desire operation.
        public int Menu()
        {
            int selection = 0;
            while (selection == 0)
            {
                Console.WriteLine("Welcome to Sales 501:");
                Console.WriteLine("1. Make a Purchase\n2. Make a Return\n3. Enter a Rebate\n4. Generate Rebate Checks\n5. Exit");
                Console.Write("Please select an operation: ");
                string temp = Console.ReadLine();
                if (temp == "1" || temp == "2" || temp == "3" || temp == "4" || temp == "5") selection = Convert.ToInt32(temp);
                else Console.WriteLine("\nInvalid Input. Please try again.");
                Console.WriteLine();
            }
            return selection;
        }

        // Creates a new transaction and stores the reciept.
        public void CheckOut()
        {
            double temp_price;
            string answer = "", temp_item = "", month;
            List<string> item = new List<string>();
            List<double> price = new List<double>();
            Console.Write("What is the current month? ");
            month = Console.ReadLine();
            do
            {
                try
                {
                    Console.Write("Enter an item: "); temp_item = Console.ReadLine();
                    Console.Write("Enter the item's price: $"); temp_price = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter another Item? (y/n): "); answer = Console.ReadLine();
                    item.Add(temp_item);
                    price.Add(temp_price);
                }
                catch (Exception)
                {
                    Console.WriteLine("\nInvalid input. Please try another value.\n");
                    CheckOut();
                }
            } while (answer == "y" || answer == "Y");
            _purchases.Add(new Transaction(month, item, price));
            Console.WriteLine();
        }

        // Creates a rebate value for a given month.
        public void GenRebate()
        {
            string month, rebate;
            double discount = 0;
            Console.Write("What month is this rebate valid? "); month = Console.ReadLine();
            while (discount == 0)
            {
                try
                {
                    Console.Write("What percentage of this rebate? "); rebate = Console.ReadLine();
                    discount = Convert.ToDouble(rebate);
                    discount /= 100;
                    if (discount > 100) throw new Exception();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please try another value.");
                    discount = 0;
                }
            }
            _rebate = new Promotion(month, discount);
            Console.WriteLine();
        }

        // Generates the refund amounts based on the given rebate.
        public void GenChecks()
        {
            try
            {
                string month = _rebate.GetMonth;
                double current_price = _rebate.GetDiscount, rebate_val, total;
                int receipt_num = 1;
                for(int j = 0; j < _purchases.Count; j++)
                {
                    rebate_val = 0; total = 0;
                    Transaction i = _purchases[j];
                    if (i.GetMonth == month)
                    {
                        Console.WriteLine("--------------------\nReceipt Number: " + receipt_num + "\n--------------------");
                        for (int k = 0; k < i.GetItem.Count; k++)
                        {
                            rebate_val += (i.GetPrice[k] * _rebate.GetDiscount);
                            total += i.GetPrice[k];
                            _discounted.Add(receipt_num);
                            
                        }                      
                        Console.WriteLine("Total Paid: " + String.Format("{0:C}", total));
                        Console.WriteLine("Total Rebate: " + String.Format("{0:C}", rebate_val) + "\n--------------------\n");
                    }
                    receipt_num++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error: No rebates found\n");
            }
        }

        // Refunds the user for a specific item and deletes it from the stored receipt.
        public void ReturnItem()
        {
            try
            {
                if (_purchases.Count == 0)
                {
                    Console.WriteLine("No Transactions Logged.\n");
                    return;
                }

                bool item_found = false;
                int receipt_num = 0;
                double refund_val = 0;
                string item;
                Console.Write("Enter the receipt number: "); receipt_num = Convert.ToInt32(Console.ReadLine());
                if(receipt_num > _purchases.Count)
                {
                    Console.WriteLine("\nNo Transactions Logged.\n");
                    return;
                }

                foreach (int i in _discounted)
                {
                    if (i == receipt_num)
                    {
                        Console.WriteLine("\nRebated items cannot be returned.\n");
                        return;
                    }
                    Console.Write("Enter the returned item: "); item = Console.ReadLine();

                    for (int j = 0; j < _purchases[receipt_num - 1].GetItem.Count; j++)
                    {
                        if (_purchases[receipt_num - 1].GetItem[j].Equals(item))
                        {
                            foreach (int k in _discounted) if (k == j) j++;
                            string value = item;
                            item_found = true;
                            refund_val += _purchases[receipt_num - 1].GetPrice[j];
                            _purchases[receipt_num - 1].GetItem.RemoveAt(j);
                            _purchases[receipt_num - 1].GetPrice.RemoveAt(j);
                            Console.WriteLine("\nReceipt Number: " + receipt_num + "\n--------------------");
                            Console.WriteLine(("Refund Amount: " + String.Format("{0:C}", refund_val) + "\n--------------------\n"));
                        }
                    }
                }
                if (!item_found) Console.WriteLine("\nItem not found.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("\nInvalid Input. Please Try Again.\n");
            }
        }
    }
}
