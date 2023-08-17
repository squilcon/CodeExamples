using Examples.Principles.SOLID._5.D.Good.Formulas;
using Examples.Principles.SOLID._5.D.Good.Write;
using Examples.Principles.SOLID._5.D.Good.Models;

namespace Examples.Principles.SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Circle logic
    /// </summary>
    internal class CircleLogic : ICircleLogic
    {
        private readonly IFormulasFactory _formulasFactory;
        private readonly IWriteFactory _writeFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formulasFactory">Instance of the interface IFormulasFactory</param>
        /// <param name="writeFactory">Instance of the interface IWriteFactory</param>
        public CircleLogic(IFormulasFactory formulasFactory,
                           IWriteFactory writeFactory)
        {
            _formulasFactory = formulasFactory;
            _writeFactory = writeFactory;
        }

        /// <inheritdoc/>
        public void Execute(Circle circle)
        {
            var area = _formulasFactory.FormulasArea().CalculateCircle(circle).CalculateArea();
            _writeFactory.File().Write(area);

            var circumference = _formulasFactory.FormulasCircumference().CalculateCircle(circle).CalculateCircumference();
            _writeFactory.Console().Write(circumference);
        }
    }
}
