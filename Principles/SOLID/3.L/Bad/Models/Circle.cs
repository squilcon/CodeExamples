using SOLID._3.L.Bad.Enums;

namespace SOLID._3.L.Bad.Models
{
    internal class Circle : Shape
    {
        public Circle(int radius)
        {
            Type = ShapeType.Circle;
            Radius = radius;
            NumberOfSides = 0; //Which is bad since a circle as infinite sides
        }

        public int Radius { get; set; }

        public override double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
