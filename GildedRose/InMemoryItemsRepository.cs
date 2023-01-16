using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public class InMemoryItemsRepository : ItemsRepository
    {
        public List<Item> items = new List<Item>()
        {
             new GenericItem("Generic", 10, 10),
            new GenericItem("Generic", 0, 10),
            new GenericItem("Generic", 5, 0),
            new AgedItem("Aged Brie", 5, 5),
            new AgedItem("Aged Brie", 5, 50),
            new LegendaryItem("Sulfuras", 5, 80),
            new EventItem("Backstage passes", 15, 5),
            new EventItem("Backstage passes", 10, 5),
            new EventItem("Backstage passes", 5, 5),
            new EventItem("Backstage passes", 0, 5),
        };
        public List<Item> GetInventory()
        {
            return items;
        }

        public void SaveInventory(List<Item> items)
        {
            
        }
    }
}
