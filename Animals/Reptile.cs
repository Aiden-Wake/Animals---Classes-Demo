using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Reptile : Animal
    {
        public Reptile(string newName, string newNoise, int agression) : base(newName, newNoise, agression)
        {
        }

        public void Swim(bool canSwim)
        {
            if (canSwim == true)
            {
                Console.WriteLine($"{name} can swim");
            }
            else
            {
                Console.WriteLine($"{name} cannot swim");
            }
        }
    }
}
