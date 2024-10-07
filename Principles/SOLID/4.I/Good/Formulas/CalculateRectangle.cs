using SOLID._4.I.Good.Models;

namespace SOLID._4.I.Good.Formulas
{
    internal class CalculateRectangle : ICalculateArea
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
    }
}
