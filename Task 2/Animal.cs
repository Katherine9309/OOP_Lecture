using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Animal : Alive
    {
        public Animal(string specie) : base(specie)

        {
        }
        public override String Specie()
        {
            return "animal";
        }
        public virtual String Individual()
        {
            return "katherin";
        }
    }
}
