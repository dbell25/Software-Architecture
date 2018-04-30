using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS_501_project_1
{
    class Program
    {
        enum ProgramState { QUIT, TRANSACTION, RETURN_ITEM, REBATE, REBATE_CHECK };

        /*
         * This is main. It controls the flow of the program.
         * It will, in later implementations, be replaced by a Controller that does the same thing.
        */
        static void Main(string[] args)
        {
            // Field Declarations:
            ProgramState program_state;
            InputOutputManager My_InputOutputManager = new InputOutputManager();
            Database My_Database = new Database();




            // Program Run
            My_InputOutputManager.DisplayIntroduction();

            while(true)
            {
                My_InputOutputManager.PromptForOperation();
                program_state = (ProgramState)My_InputOutputManager.GetOperation();


                // most program states have 2 lines of code inside of the state
                // the first is the logic that happens for that state
                // the second is a "thank you for coming" message
                if (program_state == ProgramState.TRANSACTION) // Consider this use case for Project 2
                {

                    // verbose version:
                    /*
                    List<string> list_of_items = My_InputOutputManager.GetTransactionInput();
                    string transaction_string = My_Database.CreateTransaction(list_of_items);
                    My_InputOutputManager.Display(transaction_string);
                    */                    

                    // short version of above code that also doesn't use varibles
                    My_InputOutputManager.Display(My_Database.CreateTransaction(My_InputOutputManager.GetTransactionInput()));

                    My_InputOutputManager.DisplaySuccessfulTransaction();
                }
                else if (program_state == ProgramState.RETURN_ITEM)
                {
                    /*
                    // verbose version:
                    string transaction_id = My_InputOutputManager.GetReturnTransactionID();
                    Transaction transaction = My_Database.GetTransaction(transaction_id);

                    string item = My_InputOutputManager.GetReturnItemName();

                    My_Database.RefundTransaction(transaction, item);
                    */

                    //this line does all above code without using any varibles however it is a little muddled. Better or not?
                    My_Database.RefundTransaction(My_Database.GetTransaction(My_InputOutputManager.GetReturnTransactionID()), My_InputOutputManager.GetReturnItemName());

                    My_InputOutputManager.OutputReturnItemSuccessful();
                }
                else if (program_state == ProgramState.REBATE) // Consider this use case for Project 2
                {
                    /*
                    // verbose version:
                    string transaction_id = My_InputOutputManager.GetTransactionIDForRebate();
                    Transaction transaction = My_Database.GetTransaction(transaction_id);
                    My_Database.SubmitTransactionForRebate(transaction);
                    */

                    // again this is the same code as above
                    My_Database.SubmitTransactionForRebate(My_Database.GetTransaction(My_InputOutputManager.GetTransactionIDForRebate()));

                    My_InputOutputManager.OutputRebateTransactionSuccessful();
                }
                else if (program_state == ProgramState.REBATE_CHECK)
                {
                    My_InputOutputManager.Display(My_Database.GenerateRebateCheck() + "\n");
                }
                else if (program_state == ProgramState.QUIT)
                {
                    My_InputOutputManager.OutputGoodbye();
                    return;
                }
            }

            ;
        }
    }
}
