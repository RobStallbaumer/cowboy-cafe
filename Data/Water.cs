/*
 * Author: Rob Stallbaumer
 * 
 * Water.cs
 * 
 * Class for the water
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the drink water
    /// </summary>
    public class Water : Drink, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the water it is always $.12
        /// </summary>
        public override double Price { get => .12; }

        /// <summary>
        /// Gets the calorie count of the water it is always 0
        /// </summary>
        public override uint Calories { get => 0; }

        /// <summary>
        /// backing variable for the lemon special instruction. 
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// If there is lemon or not
        /// </summary>
        public bool Lemon 
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        
        }

        //private bool ice = true;
        //public override bool Ice
        //{
        //    get { return ice; }
        //    set
        //    {
        //        ice = value;
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
        //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        //    }
        //}

        /// <summary>
        /// List of special instructions on the preperation of water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Lemon) instructions.Add("Add Lemon");
                if (!Ice) instructions.Add("Hold Ice");
                
                return instructions;
            }
        }
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Small:
                    return "Small Water";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }

    }
}
