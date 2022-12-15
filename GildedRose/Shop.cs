using System;
using System.Collections.Generic;

namespace GildedRose
{
    public class Shop
    {
        List<Item> items;
        public Shop()
        {
            items = new List<Item>();
            items.Add(new GenericItem("Wand", 9, 8));
            items.Add(new GenericItem("Sword", 10, 8));
            items.Add(new GenericItem("Shield", 5, 1));
            items.Add(new AgedItem("Aged Brie 1", 5, 4));
            items.Add(new AgedItem("Aged Brie 2", 5, 50));
            items.Add(new LegendaryItem("Sulfuras", 80));
            items.Add(new EventItem("Backstage Pass 1", 15, 10));
            items.Add(new EventItem("Backstage Pass 2", 10, 10));
            items.Add(new EventItem("Backstage Pass 3", 5, 10));
            items.Add(new EventItem("Backstage Pass 4", 3, 10));
        }

        public void UpdateInventory()
        {
            foreach (Item i in items)
            {
                i.updateQuality();
                Console.WriteLine("item :" + i.Name + " - SellIN :" + i.SellIn + " - Quality :" + i.Quality);
            }
        }

    }
           
         
}