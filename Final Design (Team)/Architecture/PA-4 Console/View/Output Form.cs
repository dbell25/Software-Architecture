using System;

namespace PA_4_Console
{
    public class OutputForm
    {
        /// <summary>
        /// Returns the output to the user.
        /// </summary>
        /// <param name="returnval"></param>
        /// <param name="status"></param>
        public void update(string returnval, State status)
        {
            Console.WriteLine("\n" + returnval + "\n");
        }
    }
}