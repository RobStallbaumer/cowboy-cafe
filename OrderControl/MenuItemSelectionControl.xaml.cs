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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Event handler adds an Angry Chicken to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new AngryChickenCustomization();
            var item = new AngryChicken();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Event handler adds a Cowpoke Chili to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowpokeChiliCustomization();
            var item = new CowpokeChili();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds a Dakota Double burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new DakotaDoubleBurgerCustomization();
            var item = new DakotaDoubleBurger();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// adds a Pecos Pulled Pork to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PecosPulledPorkCustomization();
            var item = new PecosPulledPork();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Rustlers Ribs to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new RustlersRibsCustomization();
            var item = new RustlersRibs();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Texas Triple burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTripleBurgerCustomization();
            var item = new TexasTripleBurger();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Baked Beans to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new BakedBeansCustomization();
            var item = new BakedBeans();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new ChiliCheeseFriesCustomization();
            var item = new ChiliCheeseFries();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CornDodgersCustomization();
            var item = new CornDodgers();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Pan De Campo to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PanDeCampoCustomization();
            var item = new PanDeCampo();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowboyCoffeeCustomization();
            var item = new CowboyCoffee();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Jerked Soda to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new JerkedSodaCustomization();
            var item = new JerkedSoda();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Texas Tea to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTeaCustomization();
            var item = new TexasTea();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Water to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new WaterCustomization();
            var item = new Water();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Trail burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TrailBurgerCustomization();
            var item = new TrailBurger();
            screen.DataContext = item;
            if (DataContext is Order order)
            {
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
