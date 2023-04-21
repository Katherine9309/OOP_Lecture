using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3___Task4
{
    class Fibonacci
    {
        public int limitNumber;
        public Fibonacci (int number)
        {
            limitNumber = number;
        }

        public void GetSerie()
        {
            int a = 0, b = 1;
            Console.Write("{0} {1} {2}", a, b,b+a);
            for (int c = 2; c <= limitNumber; c = a + b)
            {

                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
