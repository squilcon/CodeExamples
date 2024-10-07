using SOLID._3.L.Bad.Enums;

namespace SOLID._3.L.Bad.Models
{
    internal abstract class Shape
    {
        public ShapeType Type { get; set; }
        public int NumberOfSides { get; set; }

        public abstract double CalculateCircumference();
    }
}
