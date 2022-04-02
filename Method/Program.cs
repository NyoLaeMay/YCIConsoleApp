using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Program");
            Console.WriteLine("Enter First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            int num2=int.Parse(Console.ReadLine());
            int addResult=AddTwoValues(num1, num2);
            Console.WriteLine("The sum value of "+num1+" and "+num2+" is :"+addResult);
            Console.WriteLine("Stop Program");
            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
        static int AddTwoValues(int num1,int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static double DivideTwoValues(double num1,double num2)
        {
            double result = num1 / num2;    
            return result;
        }
    }
}
