using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public uint lastOrderNumber;

        public double Subtotal
        {
            get
            {
                double count = 0;
                foreach(IOrderItem i in items)
                {
                    count = count + i.Price;
                }
                return count;
            }
        }

        public List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

        public uint OrderNumber
        {
            get
            {
                lastOrderNumber++;
                return lastOrderNumber;
            }
        }

        public void Add(IOrderItem item) 
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item) 
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
