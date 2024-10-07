using SOLID._4.I.Bad.Enums;

namespace SOLID._4.I.Bad.Models
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
