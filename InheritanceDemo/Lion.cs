using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Lion:Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar Roar");
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void Walk()
        {
            Console.WriteLine("Lions walk with paws");
        }
    }
}
