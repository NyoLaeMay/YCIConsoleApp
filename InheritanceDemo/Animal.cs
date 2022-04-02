using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Animal//member
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Eat()//method
        {
            Console.WriteLine(name + " is eating ");
        }
        public void Sleep()//method
        {
            Console.WriteLine(name + " is sleeping ");
        }
        public virtual void Walk()
        {
            Console.WriteLine("animal is walking");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("animal is making sound");
        }
    }
}
