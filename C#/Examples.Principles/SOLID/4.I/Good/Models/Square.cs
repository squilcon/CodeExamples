using Examples.Principles.SOLID._4.I.Good.Enums;

namespace Examples.Principles.SOLID._4.I.Good.Models
{
    internal class Square : Polygon
    {
        public Square(int length)
        {
            Type = ShapeType.Square;
            Length = length;
            NumberOfSides = 4;
        }

        public int Length { get; set; }
    }
}
