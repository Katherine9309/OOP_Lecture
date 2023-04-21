using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Circle:Shape
    {
        public int radio;
        public Circle(int valueA)
        {
            radio = valueA;

        }

        public override int CalculateArea()
        {
            int area;
            area =Convert.ToInt32(radio * Math.PI);
            return area;
        }

        public override int CalculatePerimeter()
        {
            int perimeter;
            perimeter = Convert.ToInt32(2 * Math.PI*radio);
            return perimeter;
        }
    }
}
