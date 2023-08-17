using Examples.Principles.SOLID._5.D.Good.Formulas;
using Examples.Principles.SOLID._5.D.Good.Write;
using Examples.Principles.SOLID._5.D.Good.Models;

namespace Examples.Principles.SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Rectangle logic
    /// </summary>
    internal class RectangleLogic : IRectangleLogic
    {
        private readonly IFormulasFactory _formulasFactory;
        private readonly IWriteFactory _writeFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formulasFactory">Instance of the interface IFormulasFactory</param>
        /// <param name="writeFactory">Instance of the interface IWriteFactory</param>
        public RectangleLogic(IFormulasFactory formulasFactory,
                              IWriteFactory writeFactory)
        {
            _formulasFactory = formulasFactory;
            _writeFactory = writeFactory;
        }

        /// <inheritdoc/>
        public void Execute(Rectangle rectangle)
        {
            var area = _formulasFactory.FormulasArea().CalculateRectangle(rectangle).CalculateArea();
            _writeFactory.Console().Write(area);
        }
    }
}
