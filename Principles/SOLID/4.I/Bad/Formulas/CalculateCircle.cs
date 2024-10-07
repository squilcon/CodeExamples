using SOLID._4.I.Bad.Models;

namespace SOLID._4.I.Bad.Formulas
{
    internal class CalculateCircle : ICalculate
    {
        private readonly Circle _circle;

        public CalculateCircle(Circle circle)
        {
            _circle = circle;
        }

        public double Area()
        {
            return Math.PI * _circle.Radius * _circle.Radius;
        }

        public double Circumference()
        {
            return 2 * Math.PI * _circle.Radius;
        }
    }
}
