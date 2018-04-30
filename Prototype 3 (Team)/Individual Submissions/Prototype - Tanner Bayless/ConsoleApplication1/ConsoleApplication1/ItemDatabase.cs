using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ItemDatabase
    {
        public Item[] inventory;
        public Item[] buying;
        public double totalcost;
        public ItemDatabase()
        {
            Item[] nventory = { null, new Item(0, 9.47, 0), new Item(0, 10.97, 0), new Item(0, 19.97, 0), new Item(0, 13.28, 0), new Item(0, 5.97, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0) };
            Item[] uying = { null, new Item(0, 9.47, 0), new Item(0, 10.97, 0), new Item(0, 19.97, 0), new Item(0, 13.28, 0), new Item(0, 5.97, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0), new Item(0, 4.99, 0) };
            buying = uying;
            inventory = nventory;
        }
        public Item getItemFromB(int i)
        {
            return buying[i];
        }
        public string BuyingToString()
        {
            totalcost=0;
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i< 9; i++)
            {
                switch (i)
                {
                    case 1:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\n25ft. extention cord " + buying[i].numOf+"@"+buying[i].value +"      "+buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                    case 2:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\n50ft. extention cord " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\n100ft. extention cord " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                    case 4:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\n60 Watt LED Light Bulb(8-Pack) " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                    case 5:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\n60-Watt Equivalent Spiral CFL Light Bulb, Soft White (4-Pack) " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                     case 6:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\nFebreze Air Effects Hawaiian Aloha Air Freshener- 8.8oz / 2ct " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                     case 7:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\nFebreze Air Effects Linen & Sky Scent, 8.8 oz, 2 pk " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                     case 8:
                        {
                            if (buying[i].numOf > 0)
                            {
                                sb.Append("\nFebreze Air Effects Gain Original Scent, 8.8 oz, 2 pk " + buying[i].numOf + "@" + buying[i].value + "      " + buying[i].totalVal);
                                totalcost += buying[i].totalVal;
                            }
                            break;
                        }
                      default:
                            break;
                        
                }
            }
            sb.Append("\nTotal - $" + totalcost);
            return sb.ToString();
        }
    }
}