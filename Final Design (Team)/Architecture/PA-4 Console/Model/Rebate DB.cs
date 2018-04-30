using System;
using System.Collections.Generic;
using System.Text;

namespace PA_4_Console
{
    public static class RebateDB
    {
        private static List<Transaction> Rebates = new List<Transaction>();
        private static DateTime beginning = Convert.ToDateTime("06/01/2018");
        private static DateTime Ending = Convert.ToDateTime("06/30/2018");
        private static DateTime mailLimit = Convert.ToDateTime("07/15/2018");
        private static double percent = .11;

        /// <summary>
        /// Adds a transaction to a list of rebates.
        /// </summary>
        /// <param name="T"></param>
        /// <param name="Mailed"></param>
        /// <returns></returns>
        public static string AddRebateToList(Transaction T, DateTime Mailed)
	    {
            if((T.GetTD.CompareTo(beginning) >= 0 || T.GetTD.CompareTo(beginning) <= 0) && Mailed.CompareTo(mailLimit) <= 0)
            {
                Rebates.Add(T);
                return "Added To Rebate Database.";
            }
            else
            {
                return "Cannot add Rebate, not within proper Dates.";
            }
	    }

        /// <summary>
        /// Generates the refund checks.
        /// </summary>
        /// <returns></returns>
        public static string GenerateRebateChecks()
	    {
            StringBuilder sb = new StringBuilder();
            if(Rebates.Count > 0)
            {
                foreach (Transaction T in Rebates)
                {
                    sb.Append(T.IncludeRebate(percent));
                }
                Rebates.Clear();
                return sb.ToString();
            }
            else
            {
                return "There are no checks to Generate";
            }
	    }
    }
}