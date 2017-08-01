using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCodingChallenge.Shapes;

namespace UnitTests
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestCircleName()
        {
            var testCircle = new Circle(15);
            /* Circle should always be named "Circle" */
            Assert.AreEqual(testCircle.Name, "Circle");
        }

        [TestMethod]
        public void TestCircleRadius()
        {
            var testCircle = new Circle(15);
            /* Circle Radius should equal constructor param */
            Assert.AreEqual(testCircle.Radius, 15);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            var testCircle = new Circle(15);
            /* Circle with radius of 15 should always have an area of 706.86
               when rounded to 2 decimal places */
            Assert.AreEqual(Math.Round(testCircle.Area, 2), 706.86);
        }

        [TestMethod]
        public void TestCirclePerimeter()
        {
            var testCircle = new Circle(15);
            /* Circle with radius of 15 should always have an perimeter of 94.25 
               when rounded to 2 decimal places */
            Assert.AreEqual(Math.Round(testCircle.Perimeter, 2), 94.25);
        }
    }
}
