using Examples.Principles.SOLID._2.O.Good.Models;

namespace Examples.Principles.SOLID._2.O.Good.Formulas
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
    }
}
