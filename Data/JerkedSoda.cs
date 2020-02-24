using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException("Unknown Size");
                }
            }
        }

        public SodaFlavor Flavor { get; set; }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }
        /// <summary>
        /// overrides the string that this class returns when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavor;
            if(Flavor == SodaFlavor.BirchBeer)
            {
                flavor = "Birch Beer";
            }
            else if(Flavor == SodaFlavor.CreamSoda)
            {
                flavor = "Cream Soda";
            }
            else if(Flavor == SodaFlavor.OrangeSoda)
            {
                flavor = "Orange Soda";
            }
            else if(Flavor == SodaFlavor.RootBeer)
            {
                flavor = "Root Beer";
            }
            else
            {
                flavor = "Sarsparilla";
            }
            switch (Size)
            {
                case Size.Large:
                    return "Large " + flavor + " Jerked Soda";
                case Size.Medium:
                    return "Medium " + flavor + " Jerked Soda";
                case Size.Small:
                    return "Small " + flavor + " Jerked Soda";
                default:
                    throw new NotImplementedException("Unknown Size");
            }
        }
    }
}
