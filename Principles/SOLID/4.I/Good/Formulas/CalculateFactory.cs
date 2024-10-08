﻿using SOLID._4.I.Good.Enums;
using SOLID._4.I.Good.Models;

namespace SOLID._4.I.Good.Formulas
{
    internal class CalculateFactory
    {
        public ICalculateArea Instantiate(Shape shape)
        {
            return shape.Type switch
            {
                ShapeType.Square => new CalculateSquare((Square)shape),
                ShapeType.Circle => new CalculateCircle((Circle)shape),
                ShapeType.Rectangle => new CalculateRectangle((Rectangle)shape),
                _ => throw new NotImplementedException()
            };
        }
    }
}
