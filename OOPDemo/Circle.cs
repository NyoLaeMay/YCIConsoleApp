using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    public class Circle
    {
        public double Radius;
        public Circle()
        {
            Radius = 0.02;
        }
        public Circle(double newRadius)
        {
            Radius = newRadius;
        }
        public double GetArea()
        {
            double area = 0;
            area = Math.PI * Radius * Radius;
            return area;
        }
        public double GetParameter()
        {
            double parameter = 0;
            parameter = 2 * Math.PI * Radius;
            return parameter;
        }
        public void SetRadius(double newRadius)
        {
            Radius = newRadius;
        }
    }
}
