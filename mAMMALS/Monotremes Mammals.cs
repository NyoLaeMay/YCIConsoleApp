using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Monotremes_Mammals:Mammals
    {
        public void GiveBirth()
        {
            Console.WriteLine(Name + " is monotremes mammal and lay eggs.");
        }
        public void Feed()
        {
            Console.WriteLine(Name+" feed their kids with milk.");
        }
    }
}
