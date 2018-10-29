using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            if(amulet.Quality == Level.low)
            {
                return 12.5;
            }
            else if(amulet.Quality == Level.medium)
            {
                return 20;
            }
            else
            {
                return 27.5;
            }
        }
        public static double GetValueOfCourse(Course course)
        {
            int wholeHours = (int)course.DurationInMinutes / 60; 
            double price = 875 * wholeHours;
            if ((course.DurationInMinutes % 60) != 0)
            {
                price += 875;

            }
            return price;
        }
    }
}
