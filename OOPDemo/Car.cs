using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Car
    { 
            public string Color, LicenceNo, Speed;
        //define and set default value of Members by overriding default Constructor
        public Car()
        {
            Color = "No color defined";
            LicenceNo = "No licence";
            Speed = "No Speed";
        }
            public void TurnOnLight()
            {
                Console.WriteLine("Light is on");
            }
            public void PlayHorn(int playtime)
            {
                Console.WriteLine("Playing Horn");
                for (int i = 1; i <= playtime; i++)
                {
                    
                    Console.Beep();
                }
            }
            public void StartEngine()
            {
                Console.WriteLine("start engine");
            }
            public void StopEngine()
            {
                Console.WriteLine("Stop engine");
            }
        public void GetInfo()
        {
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Speed: "+Speed);
            Console.WriteLine("Licence No: " + LicenceNo);

        }
    }
}
