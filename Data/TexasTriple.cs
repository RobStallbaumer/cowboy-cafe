using System;
using System.Collections.Generic;


namespace CowboyCafe.Data
{
	public class TexasTriple
	{
        private bool bacon = true;
        /// <summary>
        /// If the Texas Triple has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        private bool egg = true;
        /// <summary>
        /// If the Texas Triple has eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// The price of the Texas Triple
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The Calories of the Texas Triple
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Special instructions for the Texas Triple
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
                
                return instructions;
            }
        }
    }
}
