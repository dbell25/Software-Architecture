using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS_501_project_1
{
    public struct Date
    {
        // Constructors:
        public Date(int day, string month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }



        // Properties:
        public int Day { get; set; }

        public string Month { get; set; }

        public int Year { get; set; }



        // Methods:
        public override string ToString()
        {
            return (Month + " " + Day + ", " + Year);
        }
    }
}