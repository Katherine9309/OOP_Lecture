using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ToString(Polynomial());
            // Polynomial().ToString();
            var number = new Polynomial(-3,4,5,6,7);
            Console.WriteLine("polynomial 1: "+ number.ToString());
            var number2 = new Polynomial(-3, 4, 5, 6, 7);
            Console.WriteLine("polynomial 2: "+ number2.ToString());
            var number3 = number - number2;
            Console.WriteLine("addiction: " + number3.ToString());
            number3 = number - number2;
            Console.WriteLine("subtraction: "+ number3.ToString());
            number3 = number * number2;
            Console.WriteLine("multiplication: " + number3.ToString());
        }
    }
}
