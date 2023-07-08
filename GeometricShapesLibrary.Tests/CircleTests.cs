using GeometricShapesLibrary.Application;
using Xunit;

namespace GeometricShapesLibrary.Tests
{
    /// <summary>
    /// Класс для тестирования окружности/>
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Тестирование вычисления площади окружности
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        /// <param name="expextedArea">Ожидаемая площадь окружности</param>
        [Theory]
        [InlineData(5, 78.539)]
        [InlineData(0.324, 0.329)]
        [InlineData(234987, 173475259694.312)]
        public void ShouldCalculateArea(double radius, double expextedArea)
        {
            var circle = ShapesFactory.CreateCircle(radius);
            Assert.Equal(expextedArea, circle.Area, 0.001);
        }

        /// <summary>
        /// Тестирование создания окружности с передачей некорректных аргументов
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        [Theory]
        [InlineData(0)]
        [InlineData(-12)]
        [InlineData(-0.78)]
        public void ShouldThrowArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => ShapesFactory.CreateCircle(radius));
        }
    }
}
