using Examples.Principles.SOLID._5.D.Good.Models;

namespace Examples.Principles.SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Circle logic
    /// </summary>
    internal interface ICircleLogic
    {
        /// <summary>
        /// Execute circle logic
        /// </summary>
        /// <param name="circle">A circle</param>
        void Execute(Circle circle);
    }
}