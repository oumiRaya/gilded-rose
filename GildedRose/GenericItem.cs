using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class GenericItem : Item
    {
        public GenericItem(string name, int sellIn, int quality)
        : base(name, sellIn, quality)
        { }

        public override void updateQuality()
        {
            this.SellIn--;
            if (this.Quality >= 1) // qualite never < 0 
            {
                this.Quality--;
            }

        }
    }
}
