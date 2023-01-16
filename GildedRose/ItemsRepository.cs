using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose
{
    public interface ItemsRepository
    {
        List<Item> GetInventory();   
        void SaveInventory(List<Item> items);
    }
}
