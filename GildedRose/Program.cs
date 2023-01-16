using System;

namespace GildedRose
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(new InMemoryItemsRepository());
            shop.UpdateQuality();
        }
    }
}
