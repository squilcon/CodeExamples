using Examples.Principles.SOLID._2.O.Good.Models;

namespace Examples.Principles.SOLID._2.O.Good.Formulas
{
    internal class CalculateSquare : ICalculate
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
