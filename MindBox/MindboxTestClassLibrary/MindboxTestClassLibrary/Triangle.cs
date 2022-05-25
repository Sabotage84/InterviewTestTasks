using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestClassLibrary
{
    public class Triangle:IShape
    {
        double a, b, c;


        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetArea()
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool CheckRight()
        {
            double k1, k2, gip;
            k1 = Math.Min(a, b);
            gip = Math.Max(a, b);
            k2 = Math.Min(c, gip);
            gip = Math.Max(c, gip);

            return k1 * k1 + k2 * k2 == gip * gip ? true : false;
        }
    }
}
