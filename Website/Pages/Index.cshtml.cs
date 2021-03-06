﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Razor.Language;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// The current search terms
        /// </summary>
        [BindProperty]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// the maximum price
        /// </summary>
        [BindProperty]
        public double? PriceMax { get; set; }

        /// <summary>
        /// the minimum price
        /// </summary>
        [BindProperty]
        public double? PriceMin { get; set; }

        /// <summary>
        /// the maximum calories
        /// </summary>
        [BindProperty]
        public uint? CalMax { get; set; }

        /// <summary>
        /// the minimum calories
        /// </summary>
        [BindProperty]
        public uint? CalMin { get; set; }

        /// <summary>
        /// the menu items that are to be displayed
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; } = MenuDatabase.All;

        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            try
            {
                PriceMin = Convert.ToDouble(Request.Query["PriceMin"]);
            }
            catch
            {
                PriceMin = null;
            }
            try
            {
                PriceMax = Convert.ToDouble(Request.Query["PriceMax"]);
            }
            catch
            {
                PriceMax = null;
            }

            try
            {
                CalMin = Convert.ToUInt32(Request.Query["CalMin"]);
            }
            catch
            {
                CalMin = null;
            }
            try
            {
                CalMax = Convert.ToUInt32(Request.Query["CalMax"]);
            }
            catch
            {
                CalMax = null;
            }
            MenuItems = MenuDatabase.All;
            //MenuItems = MenuDatabase.Search(SearchTerms);
            //MenuItems = MenuDatabase.FilterByPrice(MenuItems, PriceMin, PriceMax);
            //MenuItems = MenuDatabase.FilterByCalories(MenuItems, CalMin, CalMax);

            if (SearchTerms != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            if (PriceMax != null && PriceMin == null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Price < PriceMax);
            }
            else if(PriceMax == null && PriceMin != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Price > PriceMin);
            }
            else if(PriceMax != null && PriceMin != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Price < PriceMax &&  item.Price > PriceMin);
            }
            if (CalMax != null && CalMin == null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Calories < CalMax);
            }
            else if (CalMax == null && CalMin != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Calories > CalMin);
            }
            else if(CalMax != null && CalMin != null)
            {
                MenuItems = MenuItems.Where(item =>
                item.Calories < CalMax && item.Price > CalMin);
            }
            else
            {
                MenuItems = MenuDatabase.All;
            }
        }
    }
}
