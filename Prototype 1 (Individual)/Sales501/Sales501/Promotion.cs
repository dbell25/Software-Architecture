using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sales501
{
    public class Promotion
    {
        // stores the objects month.
        private string _month;

        // stores the dicount percentage.
        private double _discount;

        // Constructs a new promotion object.
        public Promotion(string month, double discount)
        {
            _month = month;
            _discount = discount;
        }

        // returns the discount amount.
        public double GetDiscount
        {
            get { return _discount; }
        }

        // returns the promotion's month.
        public string GetMonth
        {
            get { return _month; }
        }
    }
}