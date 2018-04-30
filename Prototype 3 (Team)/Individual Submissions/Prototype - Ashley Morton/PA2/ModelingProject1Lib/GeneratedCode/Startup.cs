
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Startup
{
    Sale createSale = new Sale();
    RebateManager createRebate = new RebateManager();
    Return createReturn = new Return();

    public void intro()
    {
        //instance
        Sale newSale = new Sale();

        string answer = "";
        Console.WriteLine("Hello. Would you like to make a (S)ale, (R)eturn, or r(E)bate? /n");
        answer = (Console.ReadLine()).ToUpper();

        if(answer == "S")
        {
            //Call sale class
            newSale.getInfo();
        }
        else if(answer == "R")
        {
            //Call Rebate Class
        }
        else if(answer == "E")
        {
            //Call Rebate
        }
        else
        {
            Console.WriteLine("Invalid anwser. /n");
        }
    }
    
}

