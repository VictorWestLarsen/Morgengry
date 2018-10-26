using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        public string ItemId;
        public string Title;
        public double Price;

        public Book(string itemId) : this (itemId, "", 0.0)
        {
            
        }
        public Book(string itemId, string title) : this (itemId, title, 0.0)
        {

        }
        public Book(string itemId, string title, double price)
        {
            ItemId = itemId;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            return "ItemId: " + ItemId + ", Title: " + Title + ", Price: " + Price;
        }
    }
}
