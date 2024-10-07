using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Formulas.Circumference;

namespace SOLID._5.D.Good.Formulas
{
    /// <summary>
    /// Factory for choosing the formulas to use
    /// </summary>
    internal class FormulasFactory : IFormulasFactory
    {
        private readonly ICalculateAreaFactory _calculateAreaFactory;
        private readonly ICalculateCircumferenceFactory _calculateCircumferenceFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="calculateAreaFactory">Instance of the interface ICalculateAreaFactory</param>
        /// <param name="calculateCircumferenceFactory">Instance of the interface ICalculateCircumferenceFactory</param>
        public FormulasFactory(ICalculateAreaFactory calculateAreaFactory,
                               ICalculateCircumferenceFactory calculateCircumferenceFactory)
        {
            _calculateAreaFactory = calculateAreaFactory;
            _calculateCircumferenceFactory = calculateCircumferenceFactory;
        }

        /// <inheritdoc/>
        public ICalculateAreaFactory FormulasArea()
        {
            return _calculateAreaFactory;
        }

        /// <inheritdoc/>
        public ICalculateCircumferenceFactory FormulasCircumference()
        {
            return _calculateCircumferenceFactory;
        }
    }
}
