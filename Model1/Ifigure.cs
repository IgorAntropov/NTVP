﻿namespace Model
{
    /// <summary>
    /// Интерфейс геометрических фигур.
    /// </summary>
    interface IFigure
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        double Square { get; }

        /// <summary>
        /// Расчет площади фигуры.
        /// </summary>
        /// <returns></returns>
        double Calculate();
    }
}
