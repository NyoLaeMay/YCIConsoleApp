﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Cat:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow Meow");
        }
        public override void Eat()
        {
            Console.WriteLine("Cats eat fish");
        }
        public override void Walk()
        {
            Console.WriteLine("Cats walk with legs");
        }
    }
}
