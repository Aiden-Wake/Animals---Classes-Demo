using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Animal
    {
        public string name;
        public int aggression;
        public int lifespan;
        public bool eatsMeat;
        public string noise;

        public Animal(string newName,string newNoise, int agression)
        {
            noise = newNoise;
            name = newName;
        }

        public void Move(double distance)
        {

        }

        public void MakeNoise()
        {
            Console.WriteLine($"{name} just said: {noise}");
        }

    }
}
