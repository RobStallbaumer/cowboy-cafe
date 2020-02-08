﻿/*
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
    public abstract class Entree
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        public abstract List<string> SpecialInstructions { get; }
    }
}
