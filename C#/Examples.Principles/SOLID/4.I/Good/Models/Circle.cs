using Examples.Principles.SOLID._4.I.Good.Enums;

namespace Examples.Principles.SOLID._4.I.Good.Models
{
    internal class Circle : Shape
    {
        public Circle(int radius)
        {
            Type = ShapeType.Circle;
            Radius = radius;
        }

        public int Radius { get; set; }
    }
}
