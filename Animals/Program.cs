using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal meerkat = new Animal("Oleg", "Compare the meeat", 15);
            meerkat.MakeNoise();

            Reptile Crocodile = new Reptile("Crocky", "Ahhhhhh!", 90);
            Crocodile.Swim(true);

            Mammal Horse = new Mammal("Bob", "Naaaahhyyy", 35);
            Horse.LaysEgg(false);

            Console.ReadLine();
        }
    }
}
