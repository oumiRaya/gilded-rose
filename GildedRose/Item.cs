using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    public abstract class Item
    {
        private string name;
        private int? sellIn ;
        private int quality;

        public Item(string name, int? sellIn , int quality)
        {
            this.name = name;
            this.sellIn = sellIn;
            this.quality = quality;
        }

        public string Name { get => name; set => name = value; }
        public int SellIn { get => (int)(sellIn.HasValue ? sellIn : -1); set => sellIn = value; }
        public int Quality { get => quality; set => quality = value; }

        public abstract void updateQuality();
    }
}