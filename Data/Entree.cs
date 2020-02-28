/*
 * Author: Rob Stallbaumer
 * 
 * Entree.cs
 * 
 * Base Class for the Entrees
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets any special instructions for the preperation of an Entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
