using SOLID._2.O.Good.Formulas;
using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Write;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Logic
{
    internal class SquareLogic : ILogic
    {
        private readonly Square _square;

        public SquareLogic(Square square)
        {
            _square = square;
        }

        public void Execute()
        {
            var area = new CalculateFactory().Instantiate(_square).Area();
            new WriteFactory().Instantiate(WriteType.Console).WriteLog(area);
        }
    }
}
