/*
 * Author: Rob Stallbaumer
 * 
 * TrailBurger.cs
 * 
 * Stores the data for the trail burger
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
	public class TrailBurger : Entree, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public bool bun = true;
        /// <summary>
        /// if the burger has a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool ketchup = true;
        /// <summary>
        /// If the Trail Burger has ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set 
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the Trail Burger has mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// if the Trail Burger has pickles
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

        private bool cheese = true;

        /// <summary>
        /// If the Trail Burger is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the Trail Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The Calories of the Trail Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the Trail Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!Bun) instructions.Add("hold bun");


                return instructions;
            }
        }
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
