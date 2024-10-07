using SOLID._5.D.Good.Formulas.Area;
using SOLID._5.D.Good.Formulas.Circumference;

namespace SOLID._5.D.Good.Formulas
{
    /// <summary>
    /// Factory for choosing the formulas to use
    /// </summary>
    internal interface IFormulasFactory
    {
        /// <summary>
        /// The factory of area formulas
        /// </summary>
        /// <returns>An instance of the class</returns>
        ICalculateAreaFactory FormulasArea();

        /// <summary>
        /// The factory of circumference forumlas
        /// </summary>
        /// <returns>An instance of the class</returns>
        ICalculateCircumferenceFactory FormulasCircumference();
    }
}