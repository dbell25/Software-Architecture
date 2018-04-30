using System;

namespace CIS_501_project_1
{
    public struct Item
    {
        // Constructors:
        public Item(string name, int id, double cost, string description = "") : this()
        {
            Name = name;
            ID = id;
            Cost = cost;
            Description = description;
        }



        // Properties:
        public String Description { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public double Cost { get; set; }



        // Methods:
        public override string ToString()
        {
            String s = "Name: " + this.Name + "\n";
            s += "ID: " + this.ID.ToString() + "\n";
            s += "Cost: " + this.Cost.ToString() + "\n";
            s += "Description: " + this.Description + "\n";

            return s;
        }
    }
}