using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    abstract class Lightstring
    {
        public Buld[] a;
        public int numberbulds;
        public Lightstring(int numberLights)
        {
            numberbulds = numberLights;
            a = new Buld[numberbulds];
        }

        public void StateBulds() {

            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            int minute = currentTime.Minutes;
            bool state = minute % 2 == 0 ? true : false;
            //call the funtion from Buld to get the state of the lights
            for (int i= 0; i < numberbulds; i++)
            {
                a[i].StateBuld(state,i);
            }
        }

        public virtual void PrintState() {
            Console.WriteLine("The lightstring state is: ");
            for (int i=0; i < numberbulds;i++ ) {
                Console.WriteLine("buld" + i + "is " + a[i]);
            }
        }
    }
}
