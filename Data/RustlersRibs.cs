using System;
using System.Collections.Generic;


namespace CowboyCafe.Data
{
	public class RustlersRibs
	{
        /// <summary>
        /// price of the Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Calorie count of the Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of Ribs
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                return instructions;
            }
        }
    }
}
