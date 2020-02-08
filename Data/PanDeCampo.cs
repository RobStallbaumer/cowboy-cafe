/*
 * Author: Rob Stallbaumer
 * 
 * PanDeCampo.cs
 * 
 * Stores data for the Pan De Campo
 * 
 */

using System;

namespace CowboyCafe.Data
{
	public class PanDeCampo : Side
	{
        /// <summary>
        /// gets the calories based on size
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
        /// <summary>
        /// gets the price based on size
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }
    }
}