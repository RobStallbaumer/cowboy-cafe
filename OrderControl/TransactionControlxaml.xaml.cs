using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CashRegister;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControlxaml.xaml
    /// </summary>
    public partial class TransactionControlxaml : UserControl
    {
        public TransactionControlxaml()
        {
            InitializeComponent();
        }

        private void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            CashDrawer cd = orderControl.cashDrawer;
            Order ord;
            if(DataContext is Order order)
            {
                
                
            }
        }

        private void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            var orderControl = this.FindAncestor<OrderControl>();
            ResultCode result;
            Order ord = null;
            if (DataContext is Order order)
            {
                result = ct.ProcessTransaction(order.Total);
                ord = order;
            }
            else result = ResultCode.UnknownErrror;

            if (result == ResultCode.Success)
            {
                PrintReceipt(ord);
                orderControl.NewOrder();
            }
            else if (result == ResultCode.ReadError)
            {
                MessageBox.Show("Read Error");

            }
            else if(result == ResultCode.UnknownErrror)
            {
                MessageBox.Show("Unknown Error");

            }
            else if (result == ResultCode.CancelledCard)
            {
                MessageBox.Show("Cancelled Card");

            }
            else if (result == ResultCode.InsufficentFunds)
            {
                MessageBox.Show("Insufficent Funds");

            }
        }

        public void PrintReceipt(Order ord)
        {
            ReceiptPrinter rp = new ReceiptPrinter();
            StringBuilder receipt = new StringBuilder();
            DateTime date = DateTime.Now.Date;
            TimeSpan time = DateTime.Now.TimeOfDay;
            string orderNumber = Convert.ToString(ord.OrderNumber);
            receipt.Append(orderNumber + "\n");
            receipt.Append(Convert.ToString(date) + "\n");
            receipt.Append(Convert.ToString(time) + "\n");
            foreach(IOrderItem i in ord.Items)
            {
                receipt.Append(Convert.ToString(i) + "\n");
            }
            rp.Print(Convert.ToString(receipt));
        }

        private void OneBillClicked(object sender, RoutedEventArgs e)
        {

        }

        private void FiveBillClicked(object sender, RoutedEventArgs e)
        {

        }

        private void TenBillClicked(object sender, RoutedEventArgs e)
        {

        }
        private void TwentyBillClicked(object sender, RoutedEventArgs e)
        {

        }
        private void FiftyBillClicked(object sender, RoutedEventArgs e)
        {

        }
        private void HunderedBillClicked(object sender, RoutedEventArgs e)
        {

        }
        private void PennyClicked(object sender, RoutedEventArgs e)
        {

        }

        private void NickleClicked(object sender, RoutedEventArgs e)
        {

        }

        private void DimeClicked(object sender, RoutedEventArgs e)
        {

        }
        private void QuarterClicked(object sender, RoutedEventArgs e)
        {

        }
        private void FiftyCentClicked(object sender, RoutedEventArgs e)
        {

        }
        private void DollarClicked(object sender, RoutedEventArgs e)
        {

        }
    }
}
