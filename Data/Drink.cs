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

namespace CowboyCafe.Data
{
    /// <summary>
    /// a base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets the price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calorie count of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets whether or not there is ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets any special instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
