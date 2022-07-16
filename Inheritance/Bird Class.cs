using System;
using System.Collections.Generic;
using System.Text;


namespace Inheritance
{
    public class Bird_Class : Animal
    {

            public bool HasWings { get; set; }
            public bool HasFeathers { get; set; }
            public bool HasClaws { get; set; }
            public bool CanFly { get; set; }


        public void PrintProps()
        {
            Console.WriteLine($"Has Scales: {HasWings}");
            Console.WriteLine($"Is Cold Blooded: {HasFeathers}");
            Console.WriteLine($"Has Tail: {HasClaws}");
            Console.WriteLine($"Lays Eggs:{CanFly}"); 
        }



    }
}
