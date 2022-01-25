using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class LeapYear
    {
        public void year()
        {
            Console.WriteLine("Enter the year to check wheather is Leap or not ");

            double year =Convert.ToDouble (Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine(year + " is a Leap Year ");
            }
             else
            {
                Console.WriteLine(year + " is not a Leap Year ");
            }
            Console.ReadLine();
        }
    }
}
