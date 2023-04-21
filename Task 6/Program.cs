using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberlights;
            Console.WriteLine("Task 6");
            Console.WriteLine("Number of lights you want: ");
            numberlights = Convert.ToInt32(Console.ReadLine());
  
            SimpleLighstring l1= new SimpleLighstring(numberlights);
            l1.StateBulds();
            l1.PrintState();

            ColoredLightstring l2 = new ColoredLightstring(numberlights);
            l2.StateBulds();
            l2.PrintState();
    


        }
    }
}
