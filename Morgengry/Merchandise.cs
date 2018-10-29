using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise
    {
        public Merchandise(string itemId)
        {
            ItemId = itemId;
        }
        public string ItemId;


        public override string ToString()
        {
            return "ItemId: " + ItemId;
        }
    }
    }

