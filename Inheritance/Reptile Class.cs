using System;
using System.Collections.Generic;
using System.Text;


namespace Inheritance
{
    public class Reptile_Class : Animal
    {
       
            public bool HasScales { get; set; }
            public bool IsColdBlooded { get; set; }
            public bool HasTail { get; set; }
            public bool LaysEggs { get; set; }

            public void PrintProps()
            {
            Console.WriteLine($"Has Scales: {HasScales}");
            Console.WriteLine($"Is Cold Blooded: {IsColdBlooded}");
            Console.WriteLine($"Has Tail: {HasTail}");
            Console.WriteLine($"Lays Eggs:{LaysEggs}");
            }
            
        
    }
}
