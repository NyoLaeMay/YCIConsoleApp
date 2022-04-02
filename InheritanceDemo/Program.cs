using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main()
        {
            Dog mydog = new Dog();
            mydog.Name = "Pukky";
            mydog.Eat();
            mydog.Sleep();
            mydog.Bark();
            mydog.Walk(2);
            mydog.Walk();
            Console.WriteLine("======================");
            Cat mycat = new Cat();
            mycat.Name = "Pussy";
            mycat.Eat();
            mycat.Sleep();
            mycat.MakeSound();
            mycat.Walk();
            Console.WriteLine("======================");
            Lion mylion = new Lion();
            mylion.Name = "Leo";
            mylion.Eat();
            mylion.Sleep();
            mylion.MakeSound();
            mylion.Walk();
            Console.WriteLine("======================");

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
