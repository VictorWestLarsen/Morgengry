using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class ValuableRepository
    {
       private List<IValuable> valuables = new List<IValuable>();

        public void GetValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string id)
        {
            foreach(IValuable valuable in valuables)
            {
                if(valuable is Merchandise merch)
                {
                    if (merch.ItemId.Equals(id))
                    {
                        return valuable;
                    }
                }
                else if (valuable is Course course)
                {
                    if (course.Name.Equals(id))
                    {
                        return valuable;
                    }
                }
            }throw new Exception("No valuable with that ID could be found");

        }
        public double GetTotalValue()
        {
            double price = 0;
            foreach(IValuable valuable in valuables)
            {
                price += valuable.GetValue();
            }
            return price;
        }

        public int count()
        {
            return valuables.Count;
        }
        }
    }

