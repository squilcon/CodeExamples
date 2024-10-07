using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas.Circumference
{
    /// <summary>
    /// Factory for choosing the circumference formula to use
    /// </summary>
    internal class CalculateCircumferenceFactory : ICalculateCircumferenceFactory
    {
        /// <inheritdoc/>
        public ICalculateCircumference CalculateCircle(Circle circle)
        {
            return new CalculateCircle(circle);
        }
    }
}