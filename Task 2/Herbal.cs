using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Herbal : Plant
    {
        public Herbal(string specie) : base(specie)
        {
            //nameSpecie = specie;
        }

        public override String Specie()
        {
            return "plant-herbal";
        }


    }
}
 