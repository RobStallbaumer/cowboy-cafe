/*
 * Author: Rob Stallbaumer
 * 
 * OrderSummaryControl.xaml.cs
 * 
 * displays the list of items and their price
 * 
 */
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
using PointOfSale.CustomizationScreens;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            var button = sender as Button;
                IOrderItem item = (button.DataContext as IOrderItem);
                orderControl.RemoveItemFromOrder(item);
            
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            IOrderItem item = (sender as ListBox).SelectedItem as IOrderItem;
            var orderControl = this.FindAncestor<OrderControl>();
            if (item is AngryChicken)
            {
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if(item is BakedBeans)
            {
                var screen = new BakedBeansCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is ChiliCheeseFries)
            {
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is CornDodgers)
            {
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is CowboyCoffee)
            {
                var screen = new CowboyCoffeeCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is CowpokeChili)
            {
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is DakotaDoubleBurger)
            {
                var screen = new DakotaDoubleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is JerkedSoda)
            {
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is PanDeCampo)
            {
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is PecosPulledPork)
            {
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is RustlersRibs)
            {
                var screen = new RustlersRibsCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is TexasTea)
            {
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is TexasTripleBurger)
            {
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is TrailBurger)
            {
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
            else if (item is Water)
            {
                var screen = new WaterCustomization();
                screen.DataContext = item;
                orderControl?.SwapScreen(screen);
            }
        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
