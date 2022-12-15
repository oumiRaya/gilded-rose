using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class AgedItem : Item
    {
        public AgedItem(string name, int sellIn, int quality)
        : base(name, sellIn, quality)
        { }
        
        public override void updateQuality()
        {
            this.SellIn--; //temps passe
             // qualite augmente
            if (this.Quality < 50) // limit qualite > 50 ;
            {
                this.Quality++;
            }
        }
    }
}
