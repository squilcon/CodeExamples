using SOLID._5.D.Good.Models;
using SOLID._5.D.Good.Logics;

namespace SOLID._5.D.Good
{
    /// <summary>
    /// The start of the program
    /// </summary>
    internal class Logic : ILogic
    {
        private readonly ILogicFactory _logicFactory;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logicFactory">Instance of the interface ILogicFactory</param>
        public Logic(ILogicFactory logicFactory)
        {
            _logicFactory = logicFactory;
        }

        /// <inheritdoc/>
        public void Execute()
        {
            var shapes = new List<Shape>()
            {
                { new Square(2) },
                { new Circle(4) },
                { new Rectangle(4, 2) }
            };

            foreach (var shape in shapes)
            {
                _logicFactory.Execute(shape);
            }
        }
    }
}
