using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Rectangle logic
    /// </summary>
    internal interface IRectangleLogic
    {
        /// <summary>
        /// Execute rectangle logic
        /// </summary>
        /// <param name="rectangle">A rectangle</param>
        void Execute(Rectangle rectangle);
    }
}