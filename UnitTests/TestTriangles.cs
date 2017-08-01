using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCodingChallenge.Shapes;

namespace UnitTests
{
    [TestClass]
    public class TestTriangles
    {
        [TestMethod]
        public void TestTriangleEquilateral()
        {
            var testEquilateral = new Triangle(5, 5, 5);
            /* Triangle with all equal sides should always be named "Equilateral" */
            Assert.AreEqual(testEquilateral.Name, "Equilateral");

            Assert.AreEqual(testEquilateral.FirstSide, 5);
            Assert.AreEqual(testEquilateral.FirstSide, testEquilateral.SecondSide);
            Assert.AreEqual(testEquilateral.FirstSide, testEquilateral.ThirdSide);
            Assert.AreEqual(testEquilateral.SecondSide, testEquilateral.ThirdSide);

            /* Triangle with dimensions of 5, 5, 5 should always have an area of 10.83
               when rounded to 2 decimal places */
            Assert.AreEqual(Math.Round(testEquilateral.Area, 2), 10.83);

            /* Triangle with dimensions of 5, 5, 5 should always have an perimeter of 15 */
            Assert.AreEqual(testEquilateral.Perimeter, 15);
        }

        [TestMethod]
        public void TestTriangleIsosceles()
        {
            var testEquilateral = new Triangle(8, 8, 5);
            /* Triangle with 2 equal sides should always be named "Isosceles" */
            Assert.AreEqual(testEquilateral.Name, "Isosceles");

            Assert.AreEqual(testEquilateral.FirstSide, 8);
            Assert.AreEqual(testEquilateral.SecondSide, 8);
            Assert.AreEqual(testEquilateral.ThirdSide, 5);
            Assert.AreEqual(testEquilateral.FirstSide, testEquilateral.SecondSide);
            Assert.AreNotEqual(testEquilateral.FirstSide, testEquilateral.ThirdSide);
            Assert.AreNotEqual(testEquilateral.SecondSide, testEquilateral.ThirdSide);

            /* Triangle with dimensions of 8, 8, 5 should always have an area of 19.00
               when rounded to 2 decimal places */
            Assert.AreEqual(Math.Round(testEquilateral.Area, 2), 19.00);

            /* Triangle with dimensions of 8, 8, 5 should always have an perimeter of 21
               when rounded to 2 decimal places */
            Assert.AreEqual(testEquilateral.Perimeter, 21);
        }

        [TestMethod]
        public void TestTriangleScalene()
        {
            var testScalene = new Triangle(12, 10, 7);
            /* Triangle with no equal sides should always be named "Scalene" */
            Assert.AreEqual(testScalene.Name, "Scalene");

            Assert.AreEqual(testScalene.FirstSide, 12);
            Assert.AreEqual(testScalene.SecondSide, 10);
            Assert.AreEqual(testScalene.ThirdSide, 7);
            Assert.AreNotEqual(testScalene.FirstSide, testScalene.SecondSide);
            Assert.AreNotEqual(testScalene.FirstSide, testScalene.ThirdSide);
            Assert.AreNotEqual(testScalene.SecondSide, testScalene.ThirdSide);

            /* Triangle with dimensions of 12, 10, 7 should always have an area of 34.98
               when rounded to 2 decimal places */
            Assert.AreEqual(Math.Round(testScalene.Area, 2), 34.98);

            /* Triangle with dimensions of 12, 10, 7 should always have an perimeter of 29
               when rounded to 2 decimal places */
            Assert.AreEqual(testScalene.Perimeter, 29);
        }
    }
}
