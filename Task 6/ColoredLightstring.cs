using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class ColoredLightstring : Lightstring
    {
        public string[] colors = { "red", "yellow", "blue", "green" };

        public ColoredLightstring(int numberLights) :base(numberLights)
        {
            int j = 0;
            for (int i=0; i < numberLights; i++) {
                
                if (j >= colors.Length){
                    j = 0;
                }
                ColoredBuld color = new ColoredBuld();
                color.SetColorType(colors[j]);
                a[i] = color;
            j++;
            }
            
        }

        public override void PrintState()
        {
            Console.WriteLine("The Colored lightstring state and color is: ");
            for (int i = 0; i < numberbulds; i++)
            {
                Console.WriteLine("buld " + i + " is " + a[i].statebuld);
                Console.WriteLine("buld " + i + " is " + a[i].GetColorType());
            }
        }

        
    }
}
