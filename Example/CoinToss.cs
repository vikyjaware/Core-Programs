using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class CoinToss
    {
        public void toss()

        {
            int Head = 0, Tail = 0;
            {
                for (int i = 0; i < 10; i++)
                {
                    Random rand = new Random();
                    int result = rand.Next(0, 2);

                    if (result > 0)
                    {
                        Head++;
                    }
                    else
                    {
                        Tail++;
                    }
                }
            }
            Console.WriteLine("Number of times Head comes =" + Head );
            Console.WriteLine("Number of times Tail comes =" + Tail );
            Console.ReadLine();
        }
    }
}
