using SOLID._2.O.Good.Enums;

namespace SOLID._2.O.Good.Models
{
    internal class Circle : Shape
    {
        public Circle(int radius)
        {
            Type = ShapeType.Circle;
            Radius = radius;
        }

        public int Radius { get; set; }

        //public override double CalculateArea()
        //{
        //    return Math.PI * Radius * Radius;
        //}
    }
}
