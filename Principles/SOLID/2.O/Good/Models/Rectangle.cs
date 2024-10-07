using SOLID._2.O.Good.Enums;

namespace SOLID._2.O.Good.Models
{
    internal class Rectangle : Shape
    {
        public Rectangle(int length, int width)
        {
            Type = ShapeType.Rectangle;
            Length = length;
            Width = width;
        }

        public int Length { get; set; }
        public int Width { get; set; }

        //public override double CalculateArea()
        //{
        //    return Length * Width;
        //}
    }
}
