using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class ReceiptDataBase
    {
        public Receipt[] ReceiptBook = new Receipt[30];
        private int index = 0;
        public void addReceipt(Receipt r)
        {
            ReceiptBook[index] = r;
            index++;
        }
    }
}