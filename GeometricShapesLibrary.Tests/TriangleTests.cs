using GeometricShapesLibrary.Application;
using GeometricShapesLibrary.Domain.Models;
using Xunit;

namespace GeometricShapesLibrary.Tests
{
    /// <summary>
    /// Класс для тестирования треугольника
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Тестирование вычисления площади треугольника
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина первой стороны</param>
        /// <param name="thirdSide">Длина первой стороны</param>
        /// <param name="expextedArea">Ожидаемая площадь треугольника</param>
        [Theory]
        [InlineData(6, 10, 8, 24)]
        [InlineData(3.33, 3.33, 3.33, 4.801)]
        [InlineData(47.12, 78.4, 82.53, 1805.696)]
        public void ShouldCalculateArea(double firstSide, double secondSide, double thirdSide,
            double expextedArea)
        {
            var triangle = ShapesFactory.CreateTriangle(firstSide, secondSide, thirdSide);
            Assert.Equal(expextedArea, triangle.Area, 0.001);
        }

        /// <summary>
        /// Тестирование создания треугольника с передачей некорректных аргументов
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина первой стороны</param>
        /// <param name="thirdSide">Длина первой стороны</param>
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-12, 23, 34)]
        [InlineData(32, 150, 10)]
        public void ShouldThrowArgumentException(double firstSide, double secondSide, double thirdSide)
        {
            Assert.Throws<ArgumentException>(() =>
                ShapesFactory.CreateTriangle(firstSide, secondSide, thirdSide));
        }

        /// <summary>
        /// Тестирование определения типа треугольника
        /// </summary>
        /// <param name="firstSide">Длина первой стороны</param>
        /// <param name="secondSide">Длина первой стороны</param>
        /// <param name="thirdSide">Длина первой стороны</param>
        /// <param name="expextedType">Ожидаемый тип треугольника</param>
        [Theory]
        [InlineData(6, 10, 8, true)]
        [InlineData(10, 10, 10, false)]
        [InlineData(34.23, 46.12, 62.76, false)]
        public void ShouldDetermineTriangleType(double firstSide, double secondSide, double thirdSide,
            bool expextedType)
        {
            var triangle = ShapesFactory.CreateTriangle(firstSide, secondSide, thirdSide) as Triangle;
            Assert.Equal(expextedType, triangle?.IsRightAngled);
        }
    }
}
