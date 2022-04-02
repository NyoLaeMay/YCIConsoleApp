using System;
namespace YCIConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] examMark = new int[5, 5];//row=5,column=5
            examMark[0, 0] = 100;
            examMark[0, 1] = 70;
            Console.WriteLine(examMark[0, 0]);//100
            Console.WriteLine(examMark[4, 4]);
            //Console.WriteLine(examMark[10, 10]);//IndexOutofBound Error will occur
            Console.WriteLine("Press any key to close this window.");
            Console.ReadKey();
        }
    }
}
