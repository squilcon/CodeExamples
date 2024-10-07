using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Factory for choosing which logic to execute
    /// </summary>
    internal interface ILogicFactory
    {
        /// <summary>
        /// Execute shape logic
        /// </summary>
        /// <param name="shape">A shape</param>
        void Execute(Shape shape);
    }
}