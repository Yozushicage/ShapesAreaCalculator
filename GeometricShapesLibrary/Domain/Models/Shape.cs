namespace GeometricShapesLibrary.Domain.Models
{
    /// <summary>
    /// Абстракция геометрической фигуры
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Площадь геометрической фигуры
        /// </summary>
        public double Area => CalculateShapeArea();

        protected abstract double CalculateShapeArea();
    }
}
