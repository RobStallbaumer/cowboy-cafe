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

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class for the Cowboy coffee
    /// </summary>
    public class CowboyCoffee : Drink
    {
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

        public bool Decaf { get; set; } = false;

        /// <summary>
        /// If there is ice in the coffee
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// If there is room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;

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
