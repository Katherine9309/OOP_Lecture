using System;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4");

            Triangle triangle = new Triangle(5,4,3);
            Circle circle = new Circle(2);
            Shape square = new Square(2);
            

            Console.WriteLine("The triangule area is: " + triangle.CalculateArea() + " and the perimeter is: "+ triangle.CalculatePerimeter() );
            Console.WriteLine("The square area " + square.CalculateArea()+ " and the perimeter is: "+ square.CalculatePerimeter());
            Console.WriteLine("The circle area " + circle.CalculateArea() + " and the perimeter is: " + circle.CalculatePerimeter());
            //circle.sideA = 3;


        }
    }
}
