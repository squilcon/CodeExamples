using SOLID._2.O.Good.Enums;

namespace SOLID._2.O.Good.Models
{
    internal class Square : Shape
    {
        public Square(int length)
        {
            Type = ShapeType.Square;
            Length = length;
        }

        public int Length { get; set; }

        //public override double CalculateArea()
        //{
        //    return Length * Length;
        //}
    }
}
