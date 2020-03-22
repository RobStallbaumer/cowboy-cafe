/*
 * Author: Rob Stallbaumer
 * 
 * Order.cs
 * 
 * The order base class
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Lets the Order Summary Control know somthing happend and it needs to update
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Keeps track of the previous order number
        /// </summary>
        private uint lastOrderNumber;
        /// <summary>
        /// gets the subtotal for the Order summary control
        /// </summary>
        public double Subtotal
        {
            get
            {
                double count = 0;
                foreach (IOrderItem i in items)
                {
                    count += i.Price;
                }
                return count;
            }

        }

        /// <summary>
        /// items list that is used by this class then transformed into an IEnumerable<IOrderItem>
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// Makes the items in the list availible for the WPF app to access
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Gets the order number
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                lastOrderNumber++;
                return lastOrderNumber;
            }
        }

        /// <summary>
        /// Adds an item to the list
        /// </summary>
        /// <param name="item">the item to be added comes from the MenuItemSelectionControl </param>
        public void Add(IOrderItem item) 
        {
            items.Add(item);
            if(item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged += OnItemChanged;                                      
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
        /// <summary>
        /// Removes an item from the list
        /// </summary>
        /// <param name="item">the item to be added comes from the MenuItemSelectionControl </param>
        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged -= OnItemChanged;                                      
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if (e.PropertyName == "Price") PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }

        public void NotifyPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
