using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIS_501_project_1
{
    public class Transaction
    {
        // Constructors:
        public Transaction(string id, Date date)
        {
            ID = id;
            Date = date;

            ItemList = new List<Item>();
            CanBeRefunded = true;
        }



        // Properties:
        public string ID { get; set; }

        public double Cost { get; set; }

        public List<Item> ItemList { get; set; }

        public bool CanBeRefunded { get; set; }
        
        public Date Date { get; set; }
        


        // Methods:
        public override string ToString()
        {
            String s = "ID: " + ID;
            s += "\nCost: " + Cost.ToString();
            s += "\nDate: " + Date;
            s += "\nItems: \n";

            foreach( Item i in ItemList )
            {
                s += "\t" + i.Name + "\n";
            }

            return s;
        }
        
        public bool AddItem(Item item)
        {
            Cost += item.Cost;
            ItemList.Add(item);

            return true;
        }

        public bool RemoveItem(Item item)
        {
            Cost -= item.Cost;
            ItemList.Remove(item);

            return true;
        }
    }
}