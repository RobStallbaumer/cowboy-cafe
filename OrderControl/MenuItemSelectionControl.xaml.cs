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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
           // orderSummaryControl.AddOrderItem(new DakotaDoubleBurger());
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            //orderSummaryControl.AddOrderItem(new PecosPulledPork());
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
           // orderSummaryControl.AddOrderItem(new RustlersRibs());
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
           // orderSummaryControl.AddOrderItem(new TexasTripleBurger());
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new BakedBeans());
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
           // orderSummaryControl.AddOrderItem(new ChiliCheeseFries());
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new CornDodgers());
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            // orderSummaryControl.AddOrderItem(new PanDeCampo());
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new CowboyCoffee());
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new JerkedSoda());
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new TexasTea());
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new Water());
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
          //  orderSummaryControl.AddOrderItem(new TrailBurger());
        }
    }
}
