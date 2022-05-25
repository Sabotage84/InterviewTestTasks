using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestClassLibrary
{
    class CircleHandler : ShapeHandler
    {
        double radius;
        public CircleHandler(double r)
        {
            radius = r;
        }

        protected override IShape GetShape()
        {
            return new Circle(radius);
        }
    }
}
