using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTestClassLibrary;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodTriangleArea()
        {
            Triangle triangle = new Triangle(11.5, 12.5, 20);
            Assert.AreEqual(66.249528, triangle.GetArea(), 0.000001);
        }

        [TestMethod]
        public void TestMethodTriangleCheckRight()
        {
            Triangle triangle1 = new Triangle(9, 15, 12);
            Assert.AreEqual(true, triangle1.CheckRight());

            Triangle triangle2 = new Triangle(2, 2, 4);
            Assert.AreEqual(false, triangle2.CheckRight());
        }

        [TestMethod]
        public void TestMethodCircleArea()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.53981625, circle.GetArea(), 0.000001);
        }

    }
}
