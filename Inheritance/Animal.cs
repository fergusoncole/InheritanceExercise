using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
            public int Legs { get; set; }
            public int Arms { get; set; }
            public string Skin { get; set; }
            public string Heart { get; set; }

            public void PrintAnimalProps()
            {
                Console.WriteLine($"Arms: {Arms}");
                Console.WriteLine($"Legs: {Legs}");
                Console.WriteLine($"Skin: {Skin}");
                Console.WriteLine($"Heart: {Heart}");
            }

    }
}
