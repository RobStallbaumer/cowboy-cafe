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
        /// <summary>
        /// Event handler adds an Angry Chicken to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// Event handler adds a Cowpoke Chili to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// adds a Dakota Double burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// adds a Pecos Pulled Pork to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// Adds Rustlers Ribs to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// Adds Texas Triple burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// Adds Baked Beans to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Adds Corn Dodgers to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Adds Pan De Campo to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// Adds Jerked Soda to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// Adds Texas Tea to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TexasTea());
            }
        }

        /// <summary>
        /// Adds Water to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new Water());
            }
        }

        /// <summary>
        /// Adds Trail burger to the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Add(new TrailBurger());
            }
        }
    }
}
