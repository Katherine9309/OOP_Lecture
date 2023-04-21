using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Omnivore:Animal
    {
        public Omnivore(string specie) : base(specie)
        {
        }

        public override String Specie()
        {
            return "omnivore animal";
        }

        public override String Individual()
        {
            return "individual francisco";
        }
    }
}

