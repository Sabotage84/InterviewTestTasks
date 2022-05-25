using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestClassLibrary
{
    class TriangleHandler : ShapeHandler
    {
        double a_side, b_side, c_side; 
        public TriangleHandler(double a, double b, double c)
        {
            a_side = a;
            b_side = b;
            c_side = c;
        }

        protected override IShape GetShape()
        {
            return new Triangle(a_side, b_side, c_side);
        }
    }
}
