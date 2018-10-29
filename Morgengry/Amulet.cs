using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level
    {
        low,
        medium,
        high,
    }
    public class Amulet : Merchandise
    {
        public Level Quality;
        public string Design;

        public Amulet(string itemId) : this (itemId, Level.medium, "")
        {
            
        }
        public Amulet(string itemId, Level quality) : this (itemId, quality, "")
        {

        }
        public Amulet(string itemId, Level quality, string design) : base(itemId)
        {
            Quality = quality;
            Design = design;
        }
        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Quality: " + Quality + ", Design: " + Design;
        }
    }
}
