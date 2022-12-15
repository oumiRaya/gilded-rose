using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class ConjuredItem : Item
    {
        public ConjuredItem(string name, int sellIn, int quality)
        : base(name, sellIn, quality)
        { }

        public override void updateQuality()
        {
            this.SellIn--;
            if (this.Quality >= 2) // qualite never < 0 
            {
                this.Quality = this.Quality - 2;
            }

        }
    }
}
