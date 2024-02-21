using CalculateSquare.Figures;


namespace CalculateSquare.Tests.Figures
{
    public class TriangleTests
    {
        public static IEnumerable<object[]> Invalid =>
            [
                [0, 4, 5],
                [3, 0, 5],
                [3, 4, 0],
                [-3, 4, 5],
                [3, -4, 5],
                [3, 4, -5],
                [double.MinValue, 4, -5],
                [3, double.MinValue, 5],
                [3, 4, double.MinValue],
                [3, 4, 8],
                [3, 8, 4],
                [8, 4, 3]
            ];
        public static IEnumerable<object[]> Valid =>
            [
                [3, 4, 5, 6],
                [3.12, 8, 5.23, 4.614941],
                [3.77, 4, 5, 7.42652],
                [3, 4.69, 5, 6.873438]
            ];

        [Theory]
        [MemberData(nameof(Invalid))]
        public void ArgumentExceptionTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Triangle triangle = Triangle.New(a, b, c);
            });
        }

        [Theory]
        [MemberData(nameof(Valid))]
        public void CalculateSquareTest(double a, double b, double c, double result)
        {
            Triangle triangle = Triangle.New(a, b, c);

            double square = triangle.CalculateSquare();

            Assert.True(Math.Abs(square - result) < 0.00001);
        }

        [Fact]
        public void RectangularTest()
        {
            Triangle triangle = Triangle.New(3, 4, 5);

            bool result = triangle.IsRectangular();

            Assert.True(result);
        }

        [Fact]
        public void NotRectangularTest()
        {
            Triangle triangle = Triangle.New(4, 4, 5);

            bool result = triangle.IsRectangular();

            Assert.False(result);
        }
    }
}