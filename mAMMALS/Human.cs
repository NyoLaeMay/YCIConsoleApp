using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Human:Placental_Mammals
    {
        public void Like()
        {
            Console.WriteLine(Name+" likes to be loved.");
        }
        public void Move()
        {
            Console.WriteLine(Name+" walks to move.");
        }
    }
}
