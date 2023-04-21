using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Scrub:Plant
    {
        public Scrub(string specie) : base(specie)
        {
          
        }
        public override String Specie()
        {
            return "plant-shrubs";
        }
    }
}
