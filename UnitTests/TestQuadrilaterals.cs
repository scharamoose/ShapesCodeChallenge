using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesCodingChallenge.Shapes;

namespace UnitTests
{
    [TestClass]
    public class TestQuadrilaterals
    {
        [TestMethod]
        public void TestSquareName()
        {
            var testSquare = new Quadrilateral(12, 12);
            /* Quadrilateral with equal height and width should always be named "Square" */
            Assert.AreEqual(testSquare.Name, "Square");
        }

        [TestMethod]
        public void TestRectangleName()
        {
            var testRectangle = new Quadrilateral(12, 15);
            /* Quadrilateral with differing height and width should always be named "Rectangle" */
            Assert.AreEqual(testRectangle.Name, "Rectangle");
        }

        [TestMethod]
        public void TestSquareDimensions()
        {
            var testSquare = new Quadrilateral(12, 12);
            /* Quadrilateral Height and Width should equal constructor params 
               and each other */
            Assert.AreEqual(testSquare.Height, testSquare.Width);
            Assert.AreEqual(testSquare.Height, 12);
            Assert.AreEqual(testSquare.Width, 12);
        }

        [TestMethod]
        public void TestRectangleDimensions()
        {
            var testRectangle = new Quadrilateral(12, 15);
            /* Quadrilateral Height and Width should equal constructor params 
               and not each other */
            Assert.AreNotEqual(testRectangle.Height, testRectangle.Width);
            Assert.AreEqual(testRectangle.Height, 12);
            Assert.AreEqual(testRectangle.Width, 15);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            var testSquare = new Quadrilateral(12, 12);
            /* Sqaure with dimensions of 12, 12 should always have an area of 144 
               when rounded to 2 decimal places */
            Assert.AreEqual(testSquare.Area, 144);
        }

        [TestMethod]
        public void TestRectangleArea()
        {
            var testRectangle = new Quadrilateral(12, 15);
            /* Rectangle with dimensions of 12, 15 should always have an area of 180
               when rounded to 2 decimal places */
            Assert.AreEqual(testRectangle.Area, 180);
        }

        [TestMethod]
        public void TestSquarePerimeter()
        {
            var testSqaure = new Quadrilateral(12, 12);
            /* Square with dimensions of 12, 12 should always have an perimeter of 48
               when rounded to 2 decimal places */
            Assert.AreEqual(testSqaure.Perimeter, 48);
        }

        [TestMethod]
        public void TestRectanglePerimeter()
        {
            var testRectangle = new Quadrilateral(12, 15);
            /* Rectangle with dimensions of 12, 15 should always have an perimeter of 54
               when rounded to 2 decimal places */
            Assert.AreEqual(testRectangle.Perimeter, 54);
        }
    }
}
