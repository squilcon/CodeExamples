using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Formulas
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
    }
}
