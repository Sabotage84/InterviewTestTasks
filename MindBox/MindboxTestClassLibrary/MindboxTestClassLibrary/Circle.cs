using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestClassLibrary
{
    public class Circle:IAreaCalculatable
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
