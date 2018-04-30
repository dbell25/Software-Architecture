
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Reciept
{
    //Instance
    Random ranNum = new Random();
    
    double price1 = 0;
    int recNum1 = 0;
    string item1;
    double total = 0;

    //holds list of items
    public void items(string item)
    {
        item1 = item;
    }

    //holds prices in a list
    public void prices(double price)
    {
        price1 = price;
        total += price;
    }

    //Generates reciept number
    public void recieptNum()
    {
        int num = Convert.ToInt32(ranNum);
    }
    
    public void totalAmount(double totaling)
    {
        total = totaling;
    }

    public void resetTotal()
    {
        total = 0;
    }
}

