using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandise = new List<Merchandise>();
        private Utility utils = new Utility(); 

        public void AddMerchandise(Merchandise merch)
        {
            merchandise.Add(merch);
        }
        public Merchandise GetMerchandise(int idx)
        {
            return merchandise[idx];
        }
        public double GetTotalValue()
        {
            double value = 0;
            foreach (Merchandise merch in merchandise)
            {
                value += utils.GetValueOfMerchandise(merch);
            }
            return value;

        }
    }
}
