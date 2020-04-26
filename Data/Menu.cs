using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new AngryChicken());
            list.Add(new CowpokeChili());
            list.Add(new DakotaDoubleBurger());
            list.Add(new PecosPulledPork());
            list.Add(new RustlersRibs());
            list.Add(new TexasTripleBurger());
            list.Add(new TrailBurger());
            IEnumerable<IOrderItem> entree = list;
            return entree;
        }

        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new BakedBeans());
            list.Add(new ChiliCheeseFries());
            list.Add(new CornDodgers());
            list.Add(new PanDeCampo());
            IEnumerable<IOrderItem> side = list;
            return side;
        }

        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new CowboyCoffee());
            list.Add(new JerkedSoda());
            list.Add(new TexasTea());
            list.Add(new Water());
            IEnumerable<IOrderItem> drink = list;
            return drink;
        }

        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.Add(new AngryChicken());
            list.Add(new CowpokeChili());
            list.Add(new DakotaDoubleBurger());
            list.Add(new PecosPulledPork());
            list.Add(new RustlersRibs());
            list.Add(new TexasTripleBurger());
            list.Add(new TrailBurger());
            list.Add(new BakedBeans());
            list.Add(new ChiliCheeseFries());
            list.Add(new CornDodgers());
            list.Add(new PanDeCampo());
            list.Add(new CowboyCoffee());
            list.Add(new JerkedSoda());
            list.Add(new TexasTea());
            list.Add(new Water());
            IEnumerable<IOrderItem> menu = list;
            return menu;
        }
    }
}
