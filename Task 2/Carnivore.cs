using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Carnivore:Animal
    {
        public bool ispredator;
        public Carnivore(string specie):base(specie)
        {
            //nameSpecie = specie;
        }

  
        public override String Specie()
        {
            var carnivore = ispredator == true ? "canivore animal predator" : " canivore animal";
            return carnivore;
        }
        public override String Individual()
        {
            return "individual karen";
        }
        public string Eat(Animal animal)
        {
            return "I'm a animal and I eat animals";
        }
    }
}

