/*
 * Author: Rob Stallbaumer
 * 
 * IOrderItem.cs
 * 
 * The order item interface

 * 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// list of special instructions that each item has
        /// </summary>
        List<string> SpecialInstructions { get; }

    }
}
