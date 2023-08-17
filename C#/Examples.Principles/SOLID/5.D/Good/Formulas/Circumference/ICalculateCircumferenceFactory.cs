using Examples.Principles.SOLID._5.D.Good.Models;

namespace Examples.Principles.SOLID._5.D.Good.Formulas.Circumference
{
    /// <summary>
    /// Factory for choosing the circumference formula to use
    /// </summary>
    internal interface ICalculateCircumferenceFactory
    {
        /// <summary>
        /// Used to calculate circle circumference
        /// </summary>
        /// <param name="circle">A circle</param>
        /// <returns>An instance</returns>
        ICalculateCircumference CalculateCircle(Circle circle);
    }
}