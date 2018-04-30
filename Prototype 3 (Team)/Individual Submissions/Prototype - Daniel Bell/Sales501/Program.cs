using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales501
{
    class Program
    {
        // Starts the program and runs the interface from the Sales class.
        public static void Main(string[] args)
        {
            Sales app = new Sales();
            while (true)
            {
                int operation = app.Menu();
                switch (operation)
                {
                    case 1: app.CheckOut(); break;
                    case 2: app.ReturnItem(); break;
                    case 3: app.GenRebate(); break;
                    case 4: app.GenChecks(); break;
                    case 5: Environment.Exit(0); break;
                }
            }
        }
    }
}