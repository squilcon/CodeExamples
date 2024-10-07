using SOLID._4.I.Good.Models;

namespace SOLID._4.I.Good.Formulas
{
    internal class CalculateSquare : ICalculateArea
    {
        private readonly Square _square;

        public CalculateSquare(Square square)
        {
            _square = square;
        }

        public double Area()
        {
            return _square.Length * _square.Length;
        }
    }
}
