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
    }
}
