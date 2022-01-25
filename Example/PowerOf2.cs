using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class PowerOf2
    {

        public void power()
        {
            Console.Write("Enter the value of exponent ");
            int value = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            Console.WriteLine(result);

            for (int i = 0; i < value; i++)
            {
                result = (result * 2);
                Console.WriteLine(result);
               
            } 
        }
    }
}
