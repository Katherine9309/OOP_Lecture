using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Buld
    {
        public string statebuld;

        public Buld() { 
        }

        public void StateBuld(bool state, int buldnumber) {
            if (state == true && (buldnumber % 2) == 0)
            {
                statebuld = "on";
            }
            else if (state == false && (buldnumber % 2) != 0) {
                statebuld = "on";
            }
            else
            { statebuld = "off"; }
            }
        public virtual string  GetColorType() { return ""; }
    }

    
}
