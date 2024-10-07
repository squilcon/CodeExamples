using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas
{
    /// <summary>
    /// Formulas for a rectangle
    /// </summary>
    internal class CalculateRectangle : ICalculateArea
    {
        private readonly Rectangle _rectangle;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rectangle">A rectangle</param>
        public CalculateRectangle(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        /// <inheritdoc/>
        public double CalculateArea()
        {
            return _rectangle.Length * _rectangle.Width;
        }
    }
}
