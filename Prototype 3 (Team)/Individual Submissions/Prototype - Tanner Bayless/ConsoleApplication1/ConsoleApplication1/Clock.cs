using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Clock
    {


        public int  Day{ get; set; }
        public int Month{ get; set; }
        public int Year { get; set; }

        public string  ToString()
        {

            string s = (Month + "/" + Day + "/" + Year);
            return s;
        }
    }
}