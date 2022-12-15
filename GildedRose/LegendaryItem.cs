using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRose
{
    class LegendaryItem : Item
    {
        public LegendaryItem(string name, int quality)
       : base(name, null , quality)
        { }

        public override void updateQuality()
        {
            // nothing happens
        }
        
    }
}
