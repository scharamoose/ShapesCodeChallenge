using System;

namespace ShapesCodingChallenge.Shapes
{
    public class Quadrilateral : Shape
    {
        private double height;
        private double width;
        // Get/Set Height
        public double Height { get => height; set => height = value; }
        // Get/Set Width
        public double Width { get => width; set => width = value; }
        // Calculate Area - Height x Width.
        public override double Area => Height * Width;
        // Calculate Perimeter using length of all sides.
        public override double Perimeter => (Height + Width) * 2;

        /// <summary>
        /// Constructor for quadrilateral, accepts 2 params of type double.
        /// The values of the params are used to determine shape definition
        /// </summary>
        /// <param name="height">radius of the quadrilateral</param>
        /// <param name="width">radius of the quadrilateral</param>
        public Quadrilateral(double height, double width)
        {
            // Determine if quadrilateral is square or rectangle
            Name = (height == width) ? "Square" : "Rectangle";
            Height = height;
            Width = width;

            DisplayOutput();
        }

        public override void DisplayOutput()
        {
            Console.WriteLine($"Shape: {Name} [Height: {Height:N2}, Width: {Width:N2}]\n");
            Console.WriteLine($"       Perimeter: {Perimeter:N2}\t\tArea: {Area:N2}\n");
        }
    }
}
