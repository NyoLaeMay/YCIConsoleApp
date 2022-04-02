using System;

namespace Assignment17
{
    public class Mammals
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Eat()//method
        {
            Console.WriteLine(name + " is eating. ");
        }
        public void Sleep()//method
        {
            Console.WriteLine(name + " is sleeping. ");
        }
      
    }
}
