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

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the drink Texas Tea
    /// </summary>
    public class TexasTea : Drink
    {

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
        /// If there is lemon in the tea or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// If the tea is sweet or not
        /// </summary>
        public bool Sweet { get; set; } = true;

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
    }
}
