using Examples.Principles.SOLID._5.D.Good.Models;
using Examples.Principles.SOLID._5.D.Good.Enums;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Examples.Principles.SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Factory for choosing the right logic
    /// </summary>
    internal class LogicFactory : ILogicFactory
    {
        private readonly ISquareLogic _squareLogic;
        private readonly ICircleLogic _circleLogic;
        private readonly IRectangleLogic _rectangleLogic;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="squareLogic">Instance of the interface ILogicSquare</param>
        /// <param name="circleLogic">Instance of the interface ILogicCircle</param>
        /// <param name="rectangleLogic">Instance of the interface ILogicRectangle</param>
        public LogicFactory(ISquareLogic squareLogic,
                            ICircleLogic circleLogic,
                            IRectangleLogic rectangleLogic)
        {
            _squareLogic = squareLogic;
            _circleLogic = circleLogic;
            _rectangleLogic = rectangleLogic;
        }

        /// <inheritdoc/>
        public void Execute(Shape shape)
        {
            switch (shape.Type)
            {
                case ShapeType.Square:
                    _squareLogic.Execute((Square)shape);
                    break;
                case ShapeType.Circle:
                    _circleLogic.Execute((Circle)shape);
                    break;
                case ShapeType.Rectangle:
                    _rectangleLogic.Execute((Rectangle)shape);
                    break;
                default:
                    break;
            }
        }

        //*****************************************************************************************************************************//
        // DISCLAIMER : The right way to use the code in comment that follows is with the factory WriteFactory if the enum still       //
        //              existed. The reason why is because the implementations have the same interface. So, the ServiceProvider could  //
        //              be use this way instead of creating new implementations like what's being done in WriteFactory.                //
        //                                                                                                                             //
        //              return writeType switch                                                                                        //
        //              {                                                                                                              //
        //                  WriteType.Console => (IWrite)_serviceProvider.GetRequiredService(typeof(WriteConsole)),                    //
        //                  WriteType.File => (IWrite)_serviceProvider.GetRequiredService(typeof(File))                                //
        //              }                                                                                                              //
        //                                                                                                                             //
        //*****************************************************************************************************************************//

        //private readonly IServiceProvider _serviceProvider;

        ///// <summary>
        ///// Constructor
        ///// </summary>
        ///// <param name="serviceProvider">Instance of the interface IServiceProvider</param>
        //public LogicFactory(IServiceProvider serviceProvider)
        //{
        //    _serviceProvider = serviceProvider;
        //}

        ///// <inheritdoc/>
        //public void Execute(Shape shape)
        //{
        //    switch (shape.Type)
        //    {
        //        case ShapeType.Square:
        //            var squareLogic = (ISquareLogic)_serviceProvider.GetRequiredService(typeof(ISquareLogic));
        //            squareLogic.Execute((Square)shape);
        //            break;
        //        case ShapeType.Circle:
        //            var circleLogic = (ICircleLogic)_serviceProvider.GetRequiredService(typeof(ICircleLogic));
        //            circleLogic.Execute((Circle)shape);
        //            break;
        //        case ShapeType.Rectangle:
        //            var rectangleLogic = (IRectangleLogic)_serviceProvider.GetRequiredService(typeof(IRectangleLogic));
        //            rectangleLogic.Execute((Rectangle)shape);
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}
