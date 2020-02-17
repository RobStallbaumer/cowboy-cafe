﻿/*
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

namespace CowboyCafe.Data
{
    /// <summary>
    /// class for the drink water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Gets the price of the water it is always $.12
        /// </summary>
        public override double Price { get => .12; }

        /// <summary>
        /// Gets the calorie count of the water it is always 0
        /// </summary>
        public override uint Calories { get => 0; }

        /// <summary>
        /// If there is lemon or not
        /// </summary>
        public bool Lemon { get; set; } = false;

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
    }
}