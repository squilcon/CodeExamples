﻿using SOLID._2.O.Good.Formulas;
using SOLID._2.O.Good.Enums;
using SOLID._2.O.Good.Write;
using SOLID._2.O.Good.Models;

namespace SOLID._2.O.Good.Logic
{
    internal class RectangleLogic : ILogic
    {
        private readonly Rectangle _rectangle;

        public RectangleLogic(Rectangle rectangle)
        {
            _rectangle = rectangle;
        }

        public void Execute()
        {
            var area = new CalculateFactory().Instantiate(_rectangle).Area();
            new WriteFactory().Instantiate(WriteType.Console).WriteLog(area);
        }
    }
}
