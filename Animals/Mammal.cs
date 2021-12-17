using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal

    {
        public Mammal(string newName, string newNoise, int agression) : base(newName, newNoise, agression)
        {
        }

        public void LaysEgg(bool canLayEgg)
        {
            string isMammal = (canLayEgg == false) ? "is" : "isn't";
            Console.WriteLine($"Your animal {isMammal} a mammal");
        }
    }
}
