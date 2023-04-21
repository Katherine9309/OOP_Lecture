using System;
using Task_2;

namespace Task_2
{
    class Program_2
        
    {
        static void Main(string[] args)
        {
            //from live beings there are two groups animals and plants where animals is divided on three groups (carnivore,omnivore,herbivore) 
            //and the plants is divide on two groups (herbs and scrub) , addicional when you are carnivore animal you have the posibility
            //to be predator
            Console.WriteLine("Hello Taks 2");
            //Console.WriteLine(/t);
            Carnivore wolf = new Carnivore("wolf"){ispredator=true};
            Herbivore rabbit = new Herbivore("rabbit");
            Omnivore bear = new Omnivore("bear");
            Plant rose = new Plant("rose");
            Herbal grass = new Herbal("grass");
           
            var livebeings = new Alive[] { wolf,rabbit, bear, rose, grass };

            foreach(var i in livebeings)
            {
                string specie = i.nameSpecie;
                Console.WriteLine("The spacie for " + specie+ " is " + i.Specie() );
 
            }
            Console.WriteLine(wolf.Individual());
            Console.WriteLine(rabbit.Eat(grass));
            Console.WriteLine(wolf.Eat(rabbit));





        }
    }
}
