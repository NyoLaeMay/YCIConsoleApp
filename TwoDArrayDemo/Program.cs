using System;
namespace TwoDArrayDemo
{
    class Program
    {
        static void Main()
        {
            
            string[] students=new string[5];
            string[] subjects = { "Myanmar", "English", "Mathematics", "Physics", "Chemistry", "Biology" };
            int[,] ExamMark = new int[5, 6];
            for(int i=0;i<5;i++)
            {
                Console.Write("enter student name  "+(i+1)+" : ");
                students[i] = Console.ReadLine();
            }
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<6;j++)
                {
                    Console.Write("Enter "+subjects[j]+" of "+students[i]+":");
                    ExamMark[i,j] = int.Parse(Console.ReadLine());

                }
                
            }//printing out from the exam mark
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col <6; col++)
                {
                    Console.Write(ExamMark[row, col] + " ,");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
