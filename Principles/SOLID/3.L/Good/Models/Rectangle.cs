using SOLID._3.L.Good.Enums;

namespace SOLID._3.L.Good.Models
{
    internal class Rectangle : Polygon
    {
        public Rectangle(int length, int width)
        {
            Type = ShapeType.Rectangle;
            Length = length;
            Width = width;
        }

        public int Length { get; set; }
        public int Width { get; set; }
    }
}
