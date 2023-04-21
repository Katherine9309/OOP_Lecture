using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Square:Shape
    {
        public int sideA;
        public Square(int valueA)
        {
            sideA = valueA;
         
        }

        public override int CalculateArea()
        {
            int area;
            area = sideA * sideA ;
            return area;
        }

        public override int CalculatePerimeter()
        {
            int perimeter;
            perimeter = sideA + sideA + sideA + sideA;
            return perimeter;
        }
    }
}
