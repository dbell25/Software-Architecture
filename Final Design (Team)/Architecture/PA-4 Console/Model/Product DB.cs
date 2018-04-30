using System;
using System.Collections.Generic;

namespace PA_4_Console
{
    public static class ProductDB
    {
        /// <summary>
        /// Hardcoded set of products.
        /// </summary>
        private static List<Product> inventory = new List<Product> //Predefined list of the store's inventory
        {
            new Product ("Milk", 1, 1.89),
            new Product ("Eggs", 2, 1.29),
            new Product ("Bacon", 3, 2.25),
            new Product ("Fidget Spinner", 4, 4.20),
            new Product ("Steak", 5, 4.50),
            new Product ("Coke", 6, 1.20),
            new Product ("Fentanyl", 7, 15.00),
            new Product ("Juice", 8, 0.89),
            new Product ("Purple Lean", 9, 5.89),
            new Product ("Plan B", 10, 70.15),
            new Product ("MiraLax", 11, 3.49),
            new Product ("Rope", 12, 4.99),
            new Product ("Trashbag", 13, 1.00),
            new Product ("Lube", 14, 5.49),
            new Product ("Tissues", 15, 2.50),
            new Product ("Kettle Chips", 16, 0.50) // Just for you Hunter <3 Michael
        };

        /// <summary>
        /// Returns a Product given an item ID number.
        /// </summary>
        /// <param name="ItemNum"></param>
        /// <returns></returns>
        public static Product GetProduct(int ItemNum)
        {
            if (inventory[ItemNum - 1].ID == ItemNum)
                return inventory[ItemNum - 1];
            else
                return FindItem(ItemNum);
        }

        /// <summary>
        /// Searches the product database for the item ID provided by the user
        /// </summary>
        /// <param name="Product_ID">Product ID</param>
        /// <returns>Product correspoinding to the giver product ID</returns>
        public static Product FindItem(int Product_ID)//may not need this if we are consistent and error check earlier
        {
            foreach(Product p in inventory)
            {
                if(p.ID == Product_ID)
                {
                    return p;
                }
            }
            Exception ex = new Exception("ERROR: Product not found!");
            throw ex;
        }

        /// <summary>
        /// Returns the store's inventory
        /// </summary>
        /// <returns>List of the store's inventory</returns>
        public static List<Product> GetProductList()
        {
            return inventory;
        }

    }

}

