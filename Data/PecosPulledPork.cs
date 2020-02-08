using System;
using System.Collections.Generic;


namespace CowboyCafe.Data
{
	public class PecosPulledPork : Entree
	{

        private bool bread = true;
        /// <summary>
        /// If the pulled pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// if the pulled pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// price of the pulled pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// calorie count of the pulled pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// special instructions for the preperation of pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
