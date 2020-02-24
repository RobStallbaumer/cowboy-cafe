/*
 * Author: Rob Stallbaumer
 * 
 * RustlersRibs.cs
 * 
 * Stores the data for the Rustlers Ribs
 * 
 */

using System;
using System.Collections.Generic;


namespace CowboyCafe.Data
{
	public class RustlersRibs : Entree
	{
        /// <summary>
        /// price of the Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Calorie count of the Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of Ribs
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
