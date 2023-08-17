using Examples.Principles.SOLID._4.I.Good.Enums;

namespace Examples.Principles.SOLID._4.I.Good.Models
{
    internal class Rectangle : Polygon
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
    }
}
