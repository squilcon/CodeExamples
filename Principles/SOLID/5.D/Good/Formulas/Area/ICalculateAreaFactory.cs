using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas.Area
{
    /// <summary>
    /// Factory for choosing the area formula to use
    /// </summary>
    internal interface ICalculateAreaFactory
    {
        /// <summary>
        /// Used to calculate square area
        /// </summary>
        /// <param name="square">A square</param>
        /// <returns>An instance</returns>
        ICalculateArea CalculateSquare(Square square);

        /// <summary>
        /// Used to calculate circle area
        /// </summary>
        /// <param name="circle">A circle</param>
        /// <returns>An instance</returns>
        ICalculateArea CalculateCircle(Circle circle);

        /// <summary>
        /// Used to calculate rectangle area
        /// </summary>
        /// <param name="rectangle">A rectangle</param>
        /// <returns>An instance</returns>
        ICalculateArea CalculateRectangle(Rectangle rectangle);
    }
}