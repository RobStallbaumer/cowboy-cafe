/*
 * Author: Rob Stallbaumer
 * 
 * CowboyCoffee.cs
 * 
 * Class for the Cowboy Coffee
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Cowboy coffee
    /// </summary>
    public class CowboyCoffee : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price depending on the size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
                        return .60;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        /// <summary>
        /// Gets the calorie count of the cowboy coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        public bool decaf = false;
        public bool Decaf 
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        
        }

        /// <summary>
        /// If there is ice in the coffee
        /// </summary>
        private bool ice = false;
        public override bool Ice
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
        /// If there is room for cream in the coffee
        /// </summary>
        public bool roomForCream;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    /// <summary>
    /// List of special instructions for the preperation of coffee
    /// </summary>
    public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                if (Decaf) instructions.Add("Decaf");

                return instructions;
            }
        }
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Decaf)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Decaf Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Decaf Cowboy Coffee";
                    case Size.Small:
                        return "Small Decaf Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown Size Decaf Cowboy Coffee");
                }
            }
            else
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Cowboy Coffee";
                    case Size.Medium:
                        return "Medium Cowboy Coffee";
                    case Size.Small:
                        return "Small Cowboy Coffee";
                    default:
                        throw new NotImplementedException("Unknown Size Cowboy Coffee");
                }
            }
        }
    }
}
