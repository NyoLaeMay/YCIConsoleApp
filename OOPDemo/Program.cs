using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Car Mycar = new Car(); //creating new object(instance of car class)
                Mycar.Color = "Black";
                Mycar.LicenceNo = "YGN-66123";
                Mycar.Speed = "2000HP";
                Mycar.StartEngine();
                Mycar.PlayHorn(3);
                Mycar.TurnOnLight();
                Mycar.StopEngine();
                Mycar.GetInfo();
                Console.WriteLine("=======================================");
                Car Yourcar = new Car();
                Yourcar.Color = "Red";
                Yourcar.LicenceNo = "YGN-963741";
                Yourcar.Speed = "1000HP";
                Yourcar.StartEngine();
                Yourcar.PlayHorn(3);
                Yourcar.TurnOnLight();
                Yourcar.StopEngine();
                Yourcar.GetInfo();

                Car c1 = new Car();
                c1.GetInfo();

                Circle circle = new Circle();//create object by using default constructor
                circle.Radius = 2.5;
                Console.WriteLine(circle.GetArea());
                Console.WriteLine(circle.GetParameter());

                Circle circle2 = new Circle(7.5);//create object by using  1 parameter constructer
                Console.WriteLine(circle.GetArea());
                Console.WriteLine(circle.GetParameter());
                circle2.SetRadius(50.5);

                Cat cat1 = new Cat();
                cat1.Sound();
                cat1.Sound(5);

                Utility.TellTodayName();
                Utility.TellTime();

                Student s1 = new Student();
                s1.SetRollNo(1);
                s1.SetAge(10);
                s1.SetName("su Su");
                s1.SetPhone("09779933643");
                s1.SetEmail("susu@gmail.com");
                s1.GetInfo();

                Student s2 = new Student();
                s2.SetRollNo(10);
                s2.SetAge(10);
                s2.SetName("khin khin");
                s2.SetPhone("09779933643");
                s2.SetEmail("khin@gmail.com");
                s2.GetInfo();

                Console.WriteLine("=================");
                Person p1 = new Person();
                p1.Name = "Mg mg";// set
                p1.Address = "N0(12),Latha Township,Yangon";
                p1.Age = 20;
                p1.Email = "mgmg@gmail.com";
                Console.WriteLine(p1.Name);//get
                Console.WriteLine(p1.Address); 
                Console.WriteLine(p1.Age);
                Console.WriteLine(p1.Email);
                Console.WriteLine("=================");
                Person p2 = new Person();
                p2.Name = "su su";
                p2.Address = "N0(12),Latha Township,Yangon";
                p2.Age =20;
                p2.Email = "susu@gmail.com";
                Console.WriteLine(p2.Name);
                Console.WriteLine(p2.Address);
                Console.WriteLine(p2.Age);
                Console.WriteLine(p2.Email);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error due to" + e.Message);
            }
           

            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
            
        }
    }
}
