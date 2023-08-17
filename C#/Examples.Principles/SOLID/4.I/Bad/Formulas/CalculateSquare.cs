using Examples.Principles.SOLID._4.I.Bad.Models;

namespace Examples.Principles.SOLID._4.I.Bad.Formulas
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

        public double Circumference()
        {
            throw new Exception("A square has no circumference");
        }
    }
}
