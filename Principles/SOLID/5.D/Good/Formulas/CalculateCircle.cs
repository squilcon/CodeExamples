using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Formulas.Circumference;
using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas
{
    /// <summary>
    /// Formulas for a circle
    /// </summary>
    internal class CalculateCircle : ICalculateArea, ICalculateCircumference 
    {
        private readonly Circle _circle;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="circle">A circle</param>
        public CalculateCircle(Circle circle)
        {
            _circle = circle;
        }

        /// <inheritdoc/>
        public double CalculateArea()
        {
            return Math.PI * _circle.Radius * _circle.Radius;
        }

        /// <inheritdoc/>
        public double CalculateCircumference()
        {
            return 2 * Math.PI * _circle.Radius;
        }
    }
}
