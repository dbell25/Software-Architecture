
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Sale
{
    //Instances
    Reciept reciept = new Reciept();
    Startup backToStart = new Startup();

    public void getInfo()
    {
        string name;
        double price;
        bool exit = true;

        while (exit)
        {
            Console.WriteLine("Item name: /n");
            name = Console.ReadLine();
            Console.WriteLine("Price");
            price = Convert.ToInt32(Console.ReadLine());

            //Adding items to reciept
            reciept.items(name);
            reciept.prices(price);

            //Send reciept to transaction

            Console.WriteLine("Do you wish to enter more items? Y/N /n");
            string answer = Console.ReadLine().ToUpper();
            if(answer != "Y")
            {
                exit = false;
                break;
            }//End if

        }//End while
        backToStart.intro();
    }

}

