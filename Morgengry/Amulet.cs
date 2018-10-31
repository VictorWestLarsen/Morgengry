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
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20;
        public double HighQualityValue = 27.5;
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
        public override double GetValue()
        {
            
            switch (Quality)
            {
                case Level.high:
                    return HighQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.low:
                    return LowQualityValue;
                default:
                    return LowQualityValue;
            }

        }
    }
}
