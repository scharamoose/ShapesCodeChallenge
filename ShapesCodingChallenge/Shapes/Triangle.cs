using System;

namespace ShapesCodingChallenge.Shapes
{
    public class Triangle : Shape
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;

        public double FirstSide { get => firstSide; set => firstSide = value; }
        public double SecondSide { get => secondSide; set => secondSide = value; }
        public double ThirdSide { get => thirdSide; set => thirdSide = value; }
        /*  Calculate Area using length of all sides only. 
            Heron's Formula [https://www.mathsisfun.com/geometry/herons-formula.html] */
        public override double Area => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - FirstSide) * ((Perimeter / 2) - SecondSide) * ((Perimeter / 2) - ThirdSide));
        //  Calculate Perimeter using length of all sides.
        public override double Perimeter => FirstSide + SecondSide + ThirdSide;

        /// <summary>
        /// Constructor for quadrilateral, accepts 3 params of type double.
        /// The values of the params are used to determine shape definition
        /// </summary>
        /// <param name="firstSide">length of 1st side of triangle</param>
        /// <param name="secondSide">length of 2nd side of triangle</param>
        /// <param name="thirdSide">length of 3rd side of triangle</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            /* Determine Triangle type: all sides same - Equilateral, */
            Name = firstSide.Equals(secondSide) && secondSide.Equals(thirdSide) ? "Equilateral" :
                    /* any 2 sides the same - Isosceles... */
                    firstSide.Equals(secondSide) || firstSide.Equals(thirdSide) || secondSide.Equals(thirdSide) ? "Isosceles" :
                        /* otherwise it's a Scalene triangle */
                        "Scalene";
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            DisplayOutput();
        }

        public override void DisplayOutput()
        {
            Console.WriteLine($"Shape: {Name} Triangle [Side 1: {FirstSide:N2} - Side 2: {SecondSide:N2} - Side 3: {ThirdSide:N2}]\n");
            Console.WriteLine($"       Perimeter: {Perimeter:N2}\t\tArea: {Area:N2}\n");
        }
    }
}
