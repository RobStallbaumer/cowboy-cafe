using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CowboyCafe.Data;
namespace Website
{
    public static class MenuDatabase
    {
        private static List<IOrderItem> displayItems = new List<IOrderItem>();


        public static IEnumerable<IOrderItem> All { get { return Menu.CompleteMenu(); } }

        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return All;

            foreach(IOrderItem item in All)
            {
                if(item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menuitems, double? min, double? max)
        {
            // If no filter is specified, just return the provided collection
            if (min == null && max == null) return menuitems;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menuitems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menuitems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in menuitems)
            {
                if (Convert.ToDouble(item.Price) > min && Convert.ToDouble(item.Price) < max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menuitems, uint? min, uint? max)
        {
            // If no filter is specified, just return the provided collection
            if (min == null && max == null) return menuitems;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in menuitems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in menuitems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in menuitems)
            {
                if (Convert.ToDouble(item.Calories) > min && Convert.ToDouble(item.Calories) < max)
                {
                    results.Add(item);
                }
            }

            return results;
        }
    }
}
