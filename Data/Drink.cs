/*
 * Author: Rob Stallbaumer
 * 
 * Drink.cs
 * 
 * Base class for the drrinks
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public virtual event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calorie count of the drink
        /// </summary>
        public abstract uint Calories { get; }


        private bool ice = true;
        /// <summary>
        /// Gets whether or not there is ice in the drink
        /// </summary>
        public virtual bool Ice 
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        /// <summary>
        /// Gets any special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
