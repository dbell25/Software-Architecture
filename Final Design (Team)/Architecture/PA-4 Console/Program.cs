using System;
using System.Threading;

namespace PA_4_Console
{
    // Observer prototype.
    public delegate void Observer(string s, State status);

    class Program
    {
        static void Main(string[] args)
        {
            TransactionController tc = new TransactionController();
            RebateController rebc = new RebateController();
            ReturnController retc = new ReturnController();
            GenerateChecksController gcc = new GenerateChecksController();
            InputForm form = new InputForm(tc.CreateTransaction, rebc.AddToRebateList, retc.ProcessReturn, gcc.GenerateChecks);
            OutputForm output = new OutputForm();

            gcc.RegisterGCC(output.update);
            tc.RegisterR(output.update);
            rebc.RegisterRC(output.update);
            retc.RegisterR(output.update);

            form.Menu();
        }
    }
}
