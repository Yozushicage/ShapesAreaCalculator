using GeometricShapesLibrary.Domain.Models;

namespace GeometricShapesLibrary.Application
{
    /// <summary>
    /// Фабрика для создания геометрических фигур
    /// </summary>
    public static class ShapesFactory
    {
        /// <summary>
        /// Создает окружность
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public static Shape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Создает треугольник
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина второй стороны</param>
        /// <param name="thirdSide">Длина третьей стороны</param>
        public static Shape CreateTriangle(double firstSide, double secondSide, double thirdSide)
        {
            return new Triangle(firstSide, secondSide, thirdSide);
        }
    }
}
