using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Formulas
{
    /// <summary>
    /// Formulas for a square
    /// </summary>
    internal class CalculateSquare : ICalculateArea
    {
        private readonly Square _square;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="square">A square</param>
        public CalculateSquare(Square square)
        {
            _square = square;
        }

        /// <inheritdoc/>
        public double CalculateArea()
        {
            return _square.Length * _square.Length;
        }
    }
}
