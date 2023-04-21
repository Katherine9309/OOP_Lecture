using System;

namespace Task3___Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type the numeber: ");
            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Fibonacci fibonacci = new Fibonacci(number);
            Console.WriteLine("Fibonacci with loop");
            fibonacci.GetSerie();
            Console.WriteLine();
            Console.WriteLine("Fibonacci with recursion");
            int a = 0, b = 1, c = 2;
            Console.Write("{0} {1} {2}", a, b, b + a);
            FibonacciRecursion(number,a,b ,c);
        }
        static void FibonacciRecursion(int number,int a,int b, int c) {
            if ( c <= number) {
                Console.Write(" {0}", c);
             
                a = b;
                b = c;
                c = a + b;
                FibonacciRecursion(number, a, b, c);
            }
        }
    }
}
