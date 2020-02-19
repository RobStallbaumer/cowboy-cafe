using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public List<string> OrderList;
        public OrderControl()
        {
            InitializeComponent();
            OrderList = new List<string>();
        }

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Angry Chicken");
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Cowpoke Chili");

        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Dakota Double Burger");

        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Pecos Pulled Pork");

        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Rustlers Ribs");

        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Texas Triple Burger");

        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Trail Burger");

        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Baked Beans");

        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Chili Cheese Fries");

        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Corn Dodgers");

        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Pan De Campo");

        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Cowboy Coffee");

        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Jerked Soda");

        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Texas Tea");

        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Add("Water");

        }

        private void OrderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
