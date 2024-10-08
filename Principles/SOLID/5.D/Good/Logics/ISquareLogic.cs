﻿using SOLID._5.D.Good.Models;

namespace SOLID._5.D.Good.Logics
{
    /// <summary>
    /// Square logic
    /// </summary>
    internal interface ISquareLogic
    {
        /// <summary>
        /// Execute square logic
        /// </summary>
        /// <param name="square">A square</param>
        void Execute(Square square);
    }
}