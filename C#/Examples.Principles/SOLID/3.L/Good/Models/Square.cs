using Examples.Principles.SOLID._3.L.Good.Enums;

namespace Examples.Principles.SOLID._3.L.Good.Models
{
    internal class Square : Polygon
    {
        public Square(int length)
        {
            Type = ShapeType.Square;
            Length = length;
        }

        public int Length { get; set; }
    }
}
