using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Placental_Mammals : Mammals
    {
        public void GiveBirth()
        {
            Console.WriteLine(Name + " is Placental mammal and the offsprings grow into a well-formed structure inside the mother’s belly for a long time before it gives birth to them when ready.");
        }
        public void Feed()
        {
            Console.WriteLine(Name + " feed their kids with milk.");
        }
    }
}
