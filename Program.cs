using System;


namespace CH20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pseudo code 1 started.");
            Console.WriteLine("========================");
            Console.Write("Enter your mark: ");
            int mark=int.Parse(Console.ReadLine());
            if(mark>=60)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            Console.WriteLine("Pseudo code 1 ended.");
            Console.WriteLine("========================");


            Console.WriteLine("Pseudo code 2 started.");
            Console.WriteLine("========================");
            float total = 0;
            int grade_counter = 1;
            while(grade_counter<=10)
            {
                Console.Write("Enter the next grade.");
                int grade=int.Parse(Console.ReadLine());
                total += grade;
                grade_counter++;
            }
            float average = total / 10;
            Console.WriteLine("The class average :"+average);

            Console.WriteLine("Pseudo code 2 ended.");
            Console.WriteLine("========================");


            Console.WriteLine("Pseudo code 3 started.");
            Console.WriteLine("========================");
            Console.Write("Enter your income: ");
            int income=int.Parse(Console.ReadLine());
            Console.Write("Enter Cost: ");
            int cost =int.Parse(Console.ReadLine());

            if(income>=cost)
            {
                int profit = income - cost;
                Console.WriteLine("Profit = "+profit);
                
            }
            else
            {
                int loss = cost - income;
                Console.WriteLine("Loss = "+loss);
                
            }

            Console.WriteLine("Pseudo code 3 ended.");
            Console.WriteLine("========================");


            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}
