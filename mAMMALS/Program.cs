using System;


namespace Assignment17
{
    class Program
    {
        static void Main()
        {
            Human human = new Human();
            human.Name = "Woman";
            human.Eat();
            human.Sleep();
            human.GiveBirth();
            human.Move();
            human.Feed();
            human.Like();
            Console.WriteLine("======================");

            Monkey m = new Monkey();
            m.Name = "Monkey";
            m.Eat();
            m.Sleep();
            m.GiveBirth();
            m.Funfact();
            m.Feed();
            m.Like();
            Console.WriteLine("======================");

            platypus p = new platypus();
            p.Name = "Platypus";
            p.Eat();
            p.Sleep();
            p.GiveBirth();
            p.Funfact();
            p.Feed();
            p.Like();
            Console.WriteLine("======================");

            echidna e = new echidna();
            e.Name = "Echidna";
            e.Eat();
            e.Sleep();
            e.GiveBirth();
            e.Funfact();
            e.Feed();
            e.Like();
            Console.WriteLine("======================");

            kangaroo k1 = new kangaroo();
            k1.Name = "Kagaroo";
            k1.Eat();
            k1.Sleep();
            k1.GiveBirth();
            k1.Funfact();
            k1.Feed();
            k1.Like();
            Console.WriteLine("======================");

            koala k2 = new koala();
            k2.Name = "Koala";
            k2.Eat();
            k2.Sleep();
            k2.GiveBirth();
            k2.Funfact();
            k2.Feed();
            k2.Like();
            Console.WriteLine("======================");

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
