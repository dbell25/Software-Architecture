using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales501
{
    public class Transaction
    {
        // stores the month of the transaction.
        private string _month;

        // stores the items purchased at checkout.
        private List<string> _item;

        // stores the price of each item.
        private List<double> _price;

        // constructs a new transaction object.
        public Transaction(string month, List<string> item, List<double> price)
        {
            _month = month;
            _item = item;
            _price = price;
        }

        // returns the item name.
        public List<string> GetItem
        {
            get { return _item; }
        }

        // returns the item month.
        public string GetMonth
        {
            get { return _month; }
        }

        // returns the item price.
        public List<double> GetPrice
        {
            get { return _price; }
        }
    }
}