using Examples.Principles.SOLID._3.L.Bad.Enums;

namespace Examples.Principles.SOLID._3.L.Bad.Models
{
    internal class Square : Shape
    {
        public Square(int length)
        {
            Type = ShapeType.Square;
            Length = length;
            NumberOfSides = 4;
        }

        public int Length { get; set; }

        public override double CalculateCircumference()
        {
            throw new NotImplementedException();
        }
    }
}
