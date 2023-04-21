using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class ColoredBuld : Buld
    {
        private string colorType;
  
        public ColoredBuld() :base()
        {

        }

        public override string GetColorType() { return colorType; }

        public void SetColorType(string value)
        {
            switch (value) {
                    case "red":
                        colorType = value;
                        break;
                    case "yellow":
                        colorType = value;
                        break;
                    case "blue":
                        colorType = value;
                        break;
                    case "green":
                        colorType = value;
                        break;
                    default:
                        Console.WriteLine("The color is not available");
                        break;
                }
           
        }
    }
}
