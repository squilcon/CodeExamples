using SOLID._5.D.Good.Formulas;
using SOLID._5.D.Good.Write;
using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Square logic
    /// </summary>
    internal class SquareLogic : ISquareLogic
    {
        private readonly IFormulasFactory _formulasFactory;
        private readonly IWriteFactory _writeFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formulasFactory">Instance of the interface IFormulasFactory</param>
        /// <param name="writeFactory">Instance of the interface IWriteFactory</param>
        public SquareLogic(IFormulasFactory formulasFactory,
                           WriteFactory writeFactory)
        {
            _formulasFactory = formulasFactory;
            _writeFactory = writeFactory;
        }

        /// <inheritdoc/>
        public void Execute(Square square)
        {
            var area = _formulasFactory.FormulasArea().CalculateSquare(square).CalculateArea();
            _writeFactory.Console().Write(area);
        }
    }
}
