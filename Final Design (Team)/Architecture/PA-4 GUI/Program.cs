using System.Threading;

namespace PA_4_GUI
{
    public delegate void Observer(string s, State status);
    class Program
    {
        static void Main(string[] args)
        {
            TransactionController tc = new TransactionController();
            RebateController rebc = new RebateController();
            ReturnController retc = new ReturnController();
            GenerateChecksController gcc = new GenerateChecksController();

            uxMainMenu main_form = new uxMainMenu(tc.CreateTransaction, rebc.AddToRebateList, retc.ProcessReturn, gcc.GenerateChecks);
            OutputForm output = new OutputForm();

            gcc.RegisterGCC(output.update);
            tc.RegisterR(output.update);
            rebc.RegisterRC(output.update);
            retc.RegisterR(output.update);

            Thread main_menu = new Thread(new ThreadStart(main_form.Run));
            main_menu.Start();
        }
    }
}
