using System;

namespace Task_2
{
    class Plant : Alive
    {

        public Plant( string space) : base(space)
        {
        }
        public override String Specie()
        {
            return "plant";
        }

    }
}


