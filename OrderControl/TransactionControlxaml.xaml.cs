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

        }

        private void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal ct = new CardTerminal();
            var orderControl = this.FindAncestor<OrderControl>();
            ResultCode result;
            if (DataContext is Order order)
            {
                result = ct.ProcessTransaction(order.Total);
            }
            else result = ResultCode.UnknownErrror;

            if (result == ResultCode.Success)
            {
                //Print receipt
            }
            else if (result == ResultCode.ReadError)
            {
                
            }
            else if(result == ResultCode.UnknownErrror)
            {

            }
            else if (result == ResultCode.CancelledCard)
            {

            }
            else if (result == ResultCode.InsufficentFunds)
            {

            }
        }
    }
}
