using SOLID._4.I.Bad.Enums;

namespace SOLID._4.I.Bad.Models
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
