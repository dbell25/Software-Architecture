
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RebateManager: Errors
{
    public static void getInfo()
    {
        //Instances
        Rebate calcRebate = new Rebate();
        //ValidReciepts isValid = new ValidReciepts();
        

        int recNum;
        Console.WriteLine("Please enter reciept number: /n");
        recNum = Convert.ToInt32(Console.ReadLine());
        
        //Check ValidReciepts
        //Since isValid is no longer a class after chnging things up
        //Add method in rebate to check validity of a reciept and have return bool
        if(isValid.CheckValidity(recNum))
        {
            //calls to calcRebate
            double rebate = calcRebate.getRebate(recNum);

            //Print rebate
            Console.WriteLine(rebate);
        }
        else
        {
            //error statement
        }

    }


}

