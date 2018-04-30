/* Author: Michael Yangmi
 * Professor: Jorge Valenzuela
 * CIS 501
 * PA-1
 * SalesItem.cs
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_1
{
    class SalesItem
    {
        private string _itemName;
        private double _itemCost;
        private double _itemCount;
        private double _itemCostTotal;


        /// <summary>
        /// Dictionary used to check if the item the user entered is valid
        /// </summary>
        public static Dictionary<string, SalesItem> storeInventoryList = new Dictionary<string, SalesItem>
        {
            ["milk"] = new SalesItem("Milk", 2.80, 1),
            ["coke"] = new SalesItem("Coke", 1.80, 1),
            ["water"] = new SalesItem("Water", .50, 1),
            ["beer"] = new SalesItem("Beer", 3.25, 1),
            ["smoothie"] = new SalesItem("Smoothie", 3.50, 1),
            ["steak"] = new SalesItem("Steak", 5.99, 1),
            ["chicken"] = new SalesItem("Chicken", 4.49, 1),
            ["turkey"] = new SalesItem("Turkey", 5.15, 1),
            ["cookies"] = new SalesItem("Cookies", .99, 1),
            ["bread"] = new SalesItem("Bread", 1.90, 1),
            ["ice cream"] = new SalesItem("Ice Cream", 3.95, 1),
            ["candy"] = new SalesItem("Candy", .40, 1),
            ["gum"] = new SalesItem("Gum", .60, 1),
            ["fidget spinner"] = new SalesItem("Fidget Spinner", 4.20, 1),
        };

        /// <summary>
        /// List of store items used for printing to console
        /// </summary>
        public static List<SalesItem> storeInventory = new List<SalesItem> {
            new SalesItem("Milk", 2.80, 1),
            new SalesItem("Coke", 1.80, 1),
            new SalesItem("Water", .50, 1),
            new SalesItem("Beer", 3.25, 1),
            new SalesItem("Smoothie", 3.50, 1),
            new SalesItem("Steak", 5.99, 1),
            new SalesItem("Chicken", 4.49, 1),
            new SalesItem("Turkey", 5.15, 1),
            new SalesItem("Cookies", .99, 1),
            new SalesItem("Bread", 1.90, 1),
            new SalesItem("Ice Cream", 3.95, 1),
            new SalesItem("Candy", .40, 1),
            new SalesItem("Gum", .60, 1),
            new SalesItem("Fidget Spinner", 4.20, 1),
        };


        /// <summary>
        /// Public constructor for the Sales b
        /// </summary>
        /// <param name="itemName">The name of the item</param>
        /// <param name="itemCost">the cost per item</param>
        /// <param name="itemCount">the total number of those items</param>
        public SalesItem(string itemName, double itemCost, double itemCount)
        {
            _itemName = itemName;
            _itemCost = itemCost;
            _itemCount = itemCount;
            _itemCostTotal = (itemCost * itemCount); //total cost of an object when accounting for the number of those items purchased
        }

        /// <summary>
        /// public getter setter for ItemCostTotal
        /// </summary>
        public double ItemCostTotal
        {
            get
            {
                return _itemCostTotal;
            }
            set
            {
                _itemCostTotal = value;
            }
        }

        /// <summary>
        /// Public getter for the ItemCost field
        /// </summary>
        public double ItemCost
        {
            get
            {
                return _itemCost;
            }
        }

        /// <summary>
        /// Public getter for the ItemCount field
        /// </summary>
        public double ItemCount
        {
            get
            {
                return _itemCount;
            }
            set
            {
                _itemCount = value;
            }
        }

        /// <summary>
        /// Public getter for the ItemName field
        /// </summary>
        public string ItemName
        {
            get
            {
                return _itemName;
            }
        }

        /// <summary>
        /// prints the stores iventory be iterating through the storeInventory list
        /// </summary>
        /// <returns>string</returns>
        public static string PrintStoreInventory()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\nThe Sales501 store's Inventory!: \n\n");
            foreach (SalesItem s in storeInventory)
            {
                sb.Append(s._itemName + " : $" + s._itemCost.ToString("f2") + "\n");
            }
            return sb.ToString();

        }

        /// <summary>
        /// string override method used for printing in a more efficient manner
        /// </summary>
        /// <returns>string with formatted price</returns>
        public override string ToString()
        {
            string msg = "Item: " + _itemName + " X " + _itemCount + " : $" + _itemCostTotal.ToString("f2");
            return msg;
        }
    }
}
