using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Marsupial_Mammals:Mammals
    {
        public void GiveBirth()
        {
            Console.WriteLine(Name + " is marsupial mammal and gives birth to the barely formed offspring, and the baby grows on a pouch on the mother’s belly.");
        }
        public void Feed()
        {
            Console.WriteLine(Name + "'s babies drink it’s milk to get all nutrients and become a fully evolved baby.");
        }
    }
}
