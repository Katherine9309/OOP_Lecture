using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class SimpleLighstring : Lightstring
    {
   
        public SimpleLighstring(int numberLights) : base(numberLights)
        {

            for (int i = 0; i < numberbulds; i++)
            {
               a[i]= new Buld();
            }
        }

        public override void PrintState()
        {
            Console.WriteLine("The simple lightstring state is: ");
            for (int i = 0; i < numberbulds; i++)
            {
                Console.WriteLine("buld " + i + " is " + a[i].statebuld);
      
            }
        }
    }
}
