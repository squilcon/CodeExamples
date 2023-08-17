using Examples.Principles.SOLID._3.L.Good.Enums;

namespace Examples.Principles.SOLID._3.L.Good.Models
{
    internal class Circle : Shape
    {
        public Circle(int radius)
        {
            Type = ShapeType.Circle;
            Radius = radius;
        }

        public int Radius { get; set; }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
