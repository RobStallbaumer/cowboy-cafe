/*
 * Author: Rob Stallbaumer
 * 
 * TexasTea.cs
 * 
 * Class for the Texas Tea
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the drink Texas Tea
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        public override event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the price of the tea depending on the size
        /// </summary>
        public override double Price 
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            } 
        }

        /// <summary>
        /// Gets the calories of the tea depending on (sweet/unsweet) and size
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException("Unknown size");
                    }
                }
            }
        }

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

        private bool sweet = true;
        /// <summary>
        /// If the tea is sweet or not
        /// </summary>
        public bool Sweet 
        { 
            get { return sweet; }
            set {
                    sweet = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool ice = true;
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
        /// Gets any special instructions for the preperation of the drink
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Lemon) instructions.Add("Add Lemon");
                if (!Sweet) instructions.Add("Unsweet");
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
            if (Sweet)
            {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Sweet Tea";
                    case Size.Medium:
                        return "Medium Texas Sweet Tea";
                    case Size.Small:
                        return "Small Texas Sweet Tea";
                    default:
                        throw new NotImplementedException("Unknown Size Texas Tea");
                }
            }
            else {
                switch (Size)
                {
                    case Size.Large:
                        return "Large Texas Plain Tea";
                    case Size.Medium:
                        return "Medium Texas Plain Tea";
                    case Size.Small:
                        return "Small Texas Plain Tea";
                    default:
                        throw new NotImplementedException("Unknown Size Texas Tea");
                }
            }
        }
    }
}
