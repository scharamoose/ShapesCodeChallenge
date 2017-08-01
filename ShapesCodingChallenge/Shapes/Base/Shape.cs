namespace ShapesCodingChallenge.Shapes
{
    /* Abstract Class - Shape */
    public abstract class Shape
    {
        public string Name;

        /* Implementation to be provided by sub classes */
        public abstract double Perimeter { get; }
        public abstract double Area { get; }

        public abstract void DisplayOutput();
    }
}
