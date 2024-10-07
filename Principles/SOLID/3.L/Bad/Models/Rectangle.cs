using SOLID._3.L.Bad.Enums;

namespace SOLID._3.L.Bad.Models
{
    internal class Rectangle : Shape
    {
        public Rectangle(int length, int width)
        {
            Type = ShapeType.Rectangle;
            Length = length;
            Width = width;
            NumberOfSides = 4;
        }

        public int Length { get; set; }
        public int Width { get; set; }

        public override double CalculateCircumference()
        {
            throw new NotImplementedException();
        }
    }
}
