using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20;
        public double HighQualityValue = 27.5;
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
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
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book book)
            {
                return book.Price;
            }
            else if (merchandise is Amulet amulet)
            {
                switch (amulet.Quality)
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
            else
            {
                return 0;
            }
        }
        }
}
