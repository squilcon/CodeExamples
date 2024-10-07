using SOLID._2.O.Good.Formulas;
using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Write;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Logic
{
    internal class CircleLogic : ILogic
    {
        private readonly Circle _circle;
        public CircleLogic(Circle circle)
        {
            _circle = circle;
        }

        public void Execute()
        {
            var area = new CalculateFactory().Instantiate(_circle).Area();
            new WriteFactory().Instantiate(WriteType.File).WriteLog(area);
        }
    }
}
