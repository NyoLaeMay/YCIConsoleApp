using System;


namespace InheritanceDemo
{
    public class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof Woof Woof");
        }
        
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        public override void Walk()
        {
            Console.WriteLine("dogs walk by foot");
        }
        public void Walk(int count)
        {
            Console.WriteLine("walking time " + count);
        }

        
    }
}
