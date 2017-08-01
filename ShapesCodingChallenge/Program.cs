using System;
using ShapesCodingChallenge.Shapes;

namespace ShapesCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Shapes:  
             *          Circle, 
             *          Quadrilaterals 
             *              - Square 
             *              - Rectangle
             *          Triangles
             *              - Equilateral
             *              - Isosceles
             *              - Scalene   
             */

            Console.WriteLine("Calculate Area and Perimeter of the following shapes:\n");

            Circle myCircle = new Circle(15);
            Quadrilateral Square = new Quadrilateral(12, 12);
            Quadrilateral Rectangle = new Quadrilateral(12, 15);
            Triangle myEquilateralTriangle = new Triangle(5, 5, 5);
            Triangle myIsoselesTriangle = new Triangle(8, 8, 5);
            Triangle myScaleneTriangle = new Triangle(12, 10, 7);

            Console.WriteLine("\n* All figures shown are rounded and displayed to 2 decimal places.");
            Console.Write("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
