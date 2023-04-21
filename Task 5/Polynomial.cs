using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Polynomial
    {
        private int x0,x1,x2,x3,x4;
        public Polynomial(int n0,int n1,int n2,int n3,int n4)
        {
            x0 = n0;
            x1 = n1;
            x2 = n2;
            x3 = n3;
            x4 = n4;
        }
      
        public override string ToString() {
            return $"{x0} + {x1}x^2 + {x2}x^5 - {x3}x^7";
        }


        public static Polynomial operator +(Polynomial p0, Polynomial p1) {
          
            return new Polynomial(p0.x0+p1.x0, p0.x1 + p1.x1, p0.x2 + p1.x2, p0.x3 + p1.x3, p0.x4 + p1.x4);
        }

        public static Polynomial operator -(Polynomial p0, Polynomial p1)
        {

            return new Polynomial(p0.x0 - p1.x0, p0.x1 - p1.x1, p0.x2 - p1.x2, p0.x3 - p1.x3, p0.x4 - p1.x4);
        }

        public static Polynomial operator *(Polynomial p0, Polynomial p1)
        {

            return new Polynomial(p0.x0 * p1.x0, p0.x1 * p1.x1, p0.x2 * p1.x2, p0.x3 * p1.x3, p0.x4 * p1.x4);
        }

    }
}
