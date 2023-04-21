using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Herbivore : Animal
    {
        public Herbivore(string specie) : base(specie)
        {
            
        }

        public override String Specie()
        {
            return "herbivore animal";
        }
        public override String Individual()
        {
            return "individual carlos";
        }

        public string Eat(Plant plant)
        {
            return "I'm a animal and I eat plants";
        }
    }
}

