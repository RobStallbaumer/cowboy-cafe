/* 
 * Edited by: Rob Stallbaumer
 * 
 * AngryChicken.cs
 * 
 * Stores data for the Angry Chicken
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <sumary>
    /// A class representing an angry chicken entree
    /// </summary>
	public class AngryChicken : Entree, INotifyPropertyChanged
	{
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private bool bread = true;
        /// <summary>
        /// If the Angry Chicken has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set 
            { 
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the Angry Chicken has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        /// <summary>
        /// Price of the Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Calorie count of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of Angry Chicken
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
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ("Angry Chicken");
        }
    }
}
