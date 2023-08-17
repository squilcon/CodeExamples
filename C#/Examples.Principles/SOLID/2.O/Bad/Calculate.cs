using Examples.Principles.SOLID._2.O.Bad.Enums;
using Examples.Principles.SOLID._2.O.Bad.Models;

namespace Examples.Principles.SOLID._2.O.Bad
{
    internal class Calculate
    {
        public double Area(Shape shape)
        {
            return shape.Type switch
            {
                ShapeType.Square => CalculateSquareArea(shape.Length),
                ShapeType.Circle => CalculateCalculateCircle(shape.Length),
                ShapeType.Rectangle => CalculateRectangleArea(shape.Length, shape.Width),
                _ => throw new NotImplementedException()
            };
        }

        private double CalculateSquareArea(int length)
        {
            return length * length;
        }

        private double CalculateCalculateCircle(int radius)
        {
            return Math.PI * radius * radius;
        }

        private double CalculateRectangleArea(int length, int width)
        {
            return length * width;
        }
    }
}