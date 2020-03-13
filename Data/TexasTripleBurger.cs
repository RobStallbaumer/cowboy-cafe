/*
 * Author: Rob Stallbaumer
 * 
 * TexasTripleBurger.cs
 * 
 * Stores the data for the Texas Triple Burger
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
	public class TexasTripleBurger : Entree, INotifyPropertyChanged
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

        private bool bacon = true;
        /// <summary>
        /// If the Texas Triple has bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set 
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool egg = true;
        /// <summary>
        /// If the Texas Triple has eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set 
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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

        private bool mayo = true;
        /// <summary>
        /// If the Dakota Double has mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If the Dakota Double has tomatoes
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the Dakota Double has lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// The price of the Texas Triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The Calories of the Texas Triple
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// Special instructions for the Texas Triple
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!mayo) instructions.Add("hold mayo");
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
            return "Texas Triple Burger";
        }
    }
}
