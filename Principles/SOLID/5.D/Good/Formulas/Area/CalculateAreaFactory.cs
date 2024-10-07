using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas.Area
{
    /// <summary>
    /// Factory for choosing the area formula to use
    /// </summary>
    internal class CalculateAreaFactory : ICalculateAreaFactory
    {
        /// <inheritdoc/>
        public ICalculateArea CalculateSquare(Square square)
        {
            return new CalculateSquare(square);
        }

        /// <inheritdoc/>
        public ICalculateArea CalculateCircle(Circle circle)
        {
            return new CalculateCircle(circle);
        }

        /// <inheritdoc/>
        public ICalculateArea CalculateRectangle(Rectangle rectangle)
        {
            return new CalculateRectangle(rectangle);
        }
    }
}