using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class EventItem : Item
    {
        public EventItem(string name, int sellIn, int quality)
       : base(name, sellIn, quality)
        { }

        public override void updateQuality()
        {
            // sellIN < 0
            if (this.SellIn < 0) //  supposons que le 0 est le jour du concert :
            {
                this.Quality = 0;
            }
            else if (this.SellIn <= 5)// 0 <= sellIN  <=5
            {
                this.Quality = this.Quality + 3;
            }
            else if(this.SellIn <= 10)// 5 < sellIN  <=10
            {
                this.Quality = this.Quality + 2;
            }

        }
    }
}
