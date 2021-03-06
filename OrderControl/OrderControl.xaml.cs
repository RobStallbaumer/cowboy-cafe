﻿/*
 * Author: Rob Stallbaumer
 * 
 * OrderControl.xaml.cs
 * 
 * combines the menu selection control and order summary control into one control along with 3 buttons
 * 
 */
 using CowboyCafe.Data;
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
using System.Windows.Shapes;
using CashRegister;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public CashDrawer cashDrawer;
        public Order order = null;
        /// <summary>
        /// Constuctor initilizes component and creates the datacontext for the ordercontrol
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            order = new Order(0);
            this.DataContext = order;
            cashDrawer = new CashDrawer();
        }

        /// <summary>
        /// Does not need to be implemented yet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Cancels the order and starts a new order in place of it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order(order.OrderNumber);
        }

        /// <summary>
        /// Compleates the order and starts a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new TransactionControlxaml();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
        public void SizeChanged()
        {
            if(this.DataContext is Order order)
            {
                order.NotifyPropertyChanged();
            }
        }

        public void NewOrder()
        {
            this.DataContext = new Order(order.OrderNumber);
            Container.Child = new MenuItemSelectionControl();
        }

        public void RemoveItemFromOrder(IOrderItem item)
        {
            if (this.DataContext is Order order)
            {
                order.Remove(item);
            }
        }
    }
}
