using GeometricShapesLibrary.Domain.Enums;

namespace GeometricShapesLibrary.Domain.Models
{
    /// <summary>
    /// Модель треугольника
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Гипотенуза
        /// </summary>
        public double Hypotenuse { get; }

        /// <summary>
        /// Первый катет
        /// </summary>
        public double FirstLeg { get; }

        /// <summary>
        /// Второй катет
        /// </summary>
        public double SecondLeg { get; }

        /// <summary>
        /// Тип треугольника (по углам)
        /// </summary>
        public AngleTriangleType TriangleType { get; }

        /// <summary>
        /// Это прямоугольный треугольник
        /// </summary>
        public bool IsRightAngled => TriangleType == AngleTriangleType.Right;

        /// <summary>
        /// .ctor
        /// </summary>
        /// <param name="firstSide">Длина первой стороны тругольника</param>
        /// <param name="secondSide">Длина второй стороны тругольника</param>
        /// <param name="thirdSide"><Длина третьей стороны треугольника/param>
        /// <exception cref="ArgumentException">Вызывается, если переданы некорректные длины сторон треугольника</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            var sides = new double[] { firstSide, secondSide, thirdSide };

            if (sides.Any(side => side <= 0))
                throw new ArgumentException("Длины сторон треугольника должны быть больше 0");

            Array.Sort(sides);

            (Hypotenuse, FirstLeg, SecondLeg) = (sides[2], sides[1], sides[0]);

            if (Hypotenuse >= FirstLeg + SecondLeg)
                throw new ArgumentException("Переданы некорректные длины сторон треугольника");

            TriangleType = DetermineTriangleType();
        }

        protected override double CalculateShapeArea()
        {
            var semiPerimeter = (Hypotenuse + FirstLeg + SecondLeg) / 2;

            return Math.Sqrt(semiPerimeter
                * (semiPerimeter - Hypotenuse)
                * (semiPerimeter - FirstLeg)
                * (semiPerimeter - SecondLeg));

        }

        private AngleTriangleType DetermineTriangleType()
        {
            var hypotenuseSquare = Math.Pow(Hypotenuse, 2);
            var legsSquaresSum = Math.Pow(FirstLeg, 2) + Math.Pow(SecondLeg, 2);

            if (hypotenuseSquare > legsSquaresSum)
                return AngleTriangleType.Obtuse;
            else if (hypotenuseSquare < legsSquaresSum)
                return AngleTriangleType.Acute;
            else
                return AngleTriangleType.Right;
        }

    }
}
