using SOLID._4.I.Bad.Models;

namespace SOLID._4.I.Bad.Formulas
{
    internal class CalculateRectangle : ICalculate
    {
        private readonly Rectangle _rectangle;

        public CalculateRectangle(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public double Area()
        {
            return _rectangle.Length * _rectangle.Width;
        }

        public double Circumference()
        {
            throw new Exception("A rectangle has no circumference");
        }
    }
}
