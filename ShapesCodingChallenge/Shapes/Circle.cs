using System;

namespace ShapesCodingChallenge.Shapes
{
    public class Circle : Shape
    {
        private double radius;

        // Get/Set Radius
        public double Radius { get => radius; set => radius = value; }
        // Calculate Area - Pi x Radius x Radius.
        public override double Area => (Radius * Radius) * Math.PI;
        // Calculate Perimeter - 2 x Pi x Radius.
        public override double Perimeter => (2 * Radius) * Math.PI;

        /// <summary>
		/// Constructor for circle, accepts param of type double
		/// </summary>
		/// <param name="radius">radius of the circle</param>
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;

            DisplayOutput();
        }

        public override void DisplayOutput()
        {
            Console.WriteLine($"Shape: {Name} [Radius: {Radius:N2}]\n");
            Console.WriteLine($"       Circumference: {Perimeter:N2}\tArea: {Area:N2}\n");
        }
    }
}
