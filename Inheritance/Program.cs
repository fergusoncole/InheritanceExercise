using System;
using System.Collections.Generic;
using System.Text;
using Inheritance;



Bird_Class birdObject1 = new Bird_Class();
birdObject1.CanFly = true;
birdObject1.HasClaws = true;
birdObject1.HasFeathers = true;
birdObject1.HasWings = true;
birdObject1.PrintProps();

Console.WriteLine("\n\n");

var snake = new Reptile_Class()
{
    HasScales = true,
    HasTail = true,
    IsColdBlooded = true,
    LaysEggs = true

};

snake.PrintProps();