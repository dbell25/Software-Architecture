﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Item
{
  
    public int numOf { get; set; }
    public double value { get; set; }
    public double totalVal { get; set; }

    public void reset()
    {
        numOf = 0;
        totalVal = 0;
    }
    public Item(int num, double val, double tot)
    {
        numOf = num;
        value = val;
        totalVal = tot;
    }

    public void add(int num)
    {
        if (num > -1)
        {
            numOf += num;
            totalVal += (num * value);
        }

    }
    public void remove(int num)
    {
        if (num > -1 && num < numOf)
        {
            numOf -= num;
            totalVal -= num * totalVal;
        }
    }
   
}

