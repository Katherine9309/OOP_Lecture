using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Alive
    {
        public string nameSpecie;
        public Alive(string specie) {
            nameSpecie = specie;
        }
        public virtual String  Specie() {
            return "living beings";
        }
    }
}
