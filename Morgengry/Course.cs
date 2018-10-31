using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes;
        public double CourseHourValue = 825;

        public Course(string name) : this (name, 0)
        {

        }

        public Course(string name, int duration)
        {
            DurationInMinutes = duration;
            Name = name;
        }
        public override string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes + ", Pris pr påbegyndt time: " + CourseHourValue ;
        }
        public double GetValue()
        {
            int wholeHours = (int)DurationInMinutes / 60;
            double price = CourseHourValue * wholeHours;
            if ((DurationInMinutes % 60) != 0)
            {
                price += CourseHourValue;
            }
            return price;
        }
    }
}
