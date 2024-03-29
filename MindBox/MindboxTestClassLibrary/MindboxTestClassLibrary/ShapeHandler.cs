﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTestClassLibrary
{
    abstract public class ShapeHandler
    {

        abstract protected IShape GetShape();
       
        public double CalculateArea(IShape shape)
        {
            return shape.GetArea();
        }

    }
}
