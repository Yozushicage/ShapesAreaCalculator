namespace GeometricShapesLibrary.Domain.Models
{
    /// <summary>
    /// Модель окружности
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <exception cref="ArgumentException">Вызывается, если передан некорректный радиус</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть больше 0");

            Radius = radius;
        }

        protected override double CalculateShapeArea() =>
            Math.PI * Math.Pow(Radius, 2);
    }
}
