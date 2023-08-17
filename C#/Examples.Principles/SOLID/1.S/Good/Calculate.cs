using Examples.Principles.SOLID._1.S.Good.Enums;
using Examples.Principles.SOLID._1.S.Good.Models;

namespace Examples.Principles.SOLID._1.S.Good
{
    internal class Calculate
    {
        public double Area(Shape shape)
        {
            return shape.Type switch
            {
                ShapeType.Square => CalculateSquareArea(shape.Length),
                ShapeType.Circle => CalculateCirecleArea(shape.Length),
                _ => throw new NotImplementedException()
            };
        }

        private double CalculateSquareArea(int length)
        {
            return length * length;
        }

        private double CalculateCirecleArea(int radius)
        {
            return Math.PI * radius * radius;
        }
    }
}