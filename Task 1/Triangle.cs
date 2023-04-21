using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Triangle:Shape
    {
        public int sideA;
        public int sideB;
        public int sideC;
        public Triangle(int valueA, int valueB, int valueC ) {
            sideA = valueA;
            sideB = valueB;
            sideC = valueC;
        }

        public override int CalculateArea() {
            int area;
            double s = (sideA+sideB+sideC)/2;
            area = Convert.ToInt32(Math.Sqrt((s*(s-sideA))*(s-sideB)*(s-sideC)));
            return area;
        }

        public override int CalculatePerimeter() {
            int perimeter;
            perimeter = sideA + sideB + sideC;
            return perimeter;
        }

    }
}
