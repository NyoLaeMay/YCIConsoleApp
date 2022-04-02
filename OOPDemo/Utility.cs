using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public static class Utility
    {
        public static int x = 100;//static class hte ka so static pr ya mal ma pr yin sematic error tat
        public static void TellTodayName()
        {
            Console.WriteLine(DateTime.Now.Day);

        }
        public static void TellTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
