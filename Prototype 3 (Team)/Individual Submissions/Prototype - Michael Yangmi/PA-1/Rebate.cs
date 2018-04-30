/* Author: Michael Yangmi
 * Professor: Jorge Valenzuela
 * CIS 501
 * PA-1
 * Rebate.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1
{
    class Rebate
    {

        private int _salesNum; //sales number the rebate is associated with
        private double _rebateValue; //how much the rebate is worth

        /// <summary>
        /// Public constructor for the rebate
        /// </summary>
        /// <param name="month">month</param>
        /// <param name="day">day</param>
        /// <param name="year">year</param>
        public Rebate(int salesNumber)
        {
            double rebateTotal = 0;
            foreach (string key in Sales501.orderHistory[salesNumber].Keys)
            {
                rebateTotal += (Sales501.orderHistory[salesNumber][key].ItemCost * Sales501.orderHistory[salesNumber][key].ItemCount);
            }


            _salesNum = salesNumber;
            _rebateValue = (rebateTotal*0.11);

        }

        /// <summary>
        /// Checks to see if the rebate is valid
        /// </summary>
        /// <param name="r">rebate object</param>
        /// <param name="d">date of the order</param>
        /// <returns>bool representing if the rebate is valid</returns>
        public static bool IsRebateValid()
        {
            Console.WriteLine("Please enter the Sales # for the sale you would like to create a rebate for: ");
            int saleNum = Convert.ToInt32(Console.ReadLine());

            if (!Sales501.orderHistory.ContainsKey(saleNum))
            {
                Console.WriteLine("ERROR: Sales number not found in our records...\nRestarting Menu...");
                return false;
            }

            string inputDate = "07/01/2018";
            Console.WriteLine("\nThe default date is \"07/01/2018\" would you like to change it? (y/n)");
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
            }



            string[] currentDate = inputDate.Split('/');                //The current date the user enters
            double currentMonth = Convert.ToDouble(currentDate[0]);
            double currentDay = Convert.ToDouble(currentDate[1]);
            double currentYear = Convert.ToDouble(currentDate[2]);

            string[] date = Sales501.orderDate[saleNum].Split('/');    //The date associated with the order the user is trying to make a rebate for.
            double month = Convert.ToDouble(date[0]);
            double day = Convert.ToDouble(date[1]);
            double year = Convert.ToDouble(date[2]);
            if (currentMonth == 6 && month == 6)
            {
                if((currentDay >= 0 && day <= currentDay) && (currentDay <= 30 && day <= currentDay))
                {
                    if(year == 2018 && currentYear == 2018)
                    {
                        Sales501.rebateList.Add(new Rebate(saleNum));
                        return true;
                    }
                }
            }
            if (currentMonth == 7 && month == 6)
            {
                if ((currentDay >= 0) && (currentDay <= 15)) //July 15th is the rebate cut off
                {
                    if (year == 2018 && currentYear == 2018)
                    {
                        Sales501.rebateList.Add(new Rebate(saleNum));
                        return true;
                    }
                }
            }
            return false;
        }


        /// <summary>
        /// Generates the rebate checks stored in the Sales501.rebateList and formats it
        /// </summary>
        public static void GenerateRebate()
        {
            if(Sales501.rebateList.Count == 0)
            {
                Console.WriteLine("\nERROR: THERE ARE NO REBATES TO BE GENERATED");
                return;
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            foreach(Rebate r in Sales501.rebateList)
            {
                double total = 0;
                foreach(string keys in Sales501.orderHistory[r._salesNum].Keys)
                {
                    total += Sales501.orderHistory[r._salesNum][keys].ItemCostTotal;
                }
                total = total * .11;
                Console.WriteLine("Rebate Generated for Sale #" + r._salesNum + " is totaled to: $" + total.ToString("f2"));
                Sales501.rebateHistory.Add(r._salesNum, true);
            }
            Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");

        }
        
    }
}
