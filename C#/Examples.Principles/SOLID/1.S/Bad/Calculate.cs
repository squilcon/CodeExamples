using Examples.Principles.SOLID._1.S.Bad.Enums;
using Examples.Principles.SOLID._1.S.Bad.Models;

namespace Examples.Principles.SOLID._1.S.Bad
{
    internal class Calculate
    {
        public void Area(Shape shape)
        {
            switch (shape.Type)
            {
                case ShapeType.Square:
                    CalculateSquareArea(shape.Length);
                    break;
                case ShapeType.Circle:
                    CalculateCircle(shape.Length);
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void CalculateSquareArea(int length)
        {
            var area = length * length;
            LogArea(area);
        }

        private void CalculateCircle(int radius)
        {
            var area = Math.PI * radius * radius;
            LogArea(area);
        }

        private void LogArea(double area)
        {
            Console.WriteLine(area.ToString());
        }
    }
}