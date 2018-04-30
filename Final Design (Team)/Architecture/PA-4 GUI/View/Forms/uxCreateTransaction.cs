using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PA_4_GUI
{
    public partial class uxCreateTransaction : Form
    {
        private List<Tuple<int, int>> cart = new List<Tuple<int, int>>();
        private ICreateTransaction transaction_handler;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        /// <param name="tr"></param>
        public uxCreateTransaction(ICreateTransaction tr)
        {
            InitializeComponent();
            transaction_handler = tr;
            ShowItems();
        }

        /// <summary>
        /// Shows the items available for purchase.
        /// </summary>
        public void ShowItems()
        {
            trans_DisplayItems.Text = "";
            List<Product> items_available = ProductDB.GetProductList();

            trans_DisplayItems.Text += "\nID:\tName:\t\tPrice:\n";
            for (int i = 0; i < items_available.Count; i++)
            {
                trans_DisplayItems.Text += (items_available[i].ID + "\t" + items_available[i].GetName);
                if (items_available[i].GetName.Length > 7) trans_DisplayItems.Text += "\t";
                else trans_DisplayItems.Text += ("\t\t");
                trans_DisplayItems.Text += ("$" + items_available[i].GetPrice + "\n");
            }
        }

        /// <summary>
        /// Runs the form.
        /// </summary>
        public void Run()
        {
            Application.Run(this);
        }

        /// <summary>
        /// Handles the add to cart click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trans_CreateTransaction_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(trans_ItemNumVal.Value), Quantity = Convert.ToInt32(trans_ItemQuantityVal.Value);
            Tuple<int, int> temp = new Tuple<int, int>(ID, Quantity);
            cart.Add(temp);
            MessageBox.Show("Item successfully added to cart!");
        }

        /// <summary>
        /// Handles the create transaction click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trans_FinishTransaction_Click(object sender, EventArgs e)
        {
            transaction_handler(cart);
        }
    }   
}
