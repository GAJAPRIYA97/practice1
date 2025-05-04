using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Namelist
    {
        public void WeekdayMethod()
        {
            List<string> Weekday = new List<string>();
            Weekday.AddRange(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "friday", "saturday" });
            Console.WriteLine("Days of the week: ");
            foreach (string day in Weekday)
            {
                Console.WriteLine(day);
            }
        }
    }    }
    





















            

        



