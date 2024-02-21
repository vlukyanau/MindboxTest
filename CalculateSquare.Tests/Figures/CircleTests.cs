using CalculateSquare.Figures;


namespace CalculateSquare.Tests.Figures
{
    public class CircleTests
    {
        public static IEnumerable<object[]> Invalid =>
            [
                [-2],
                [double.MinValue],
                [0]
            ];
        public static IEnumerable<object[]> Valid =>
            [
                [20, 1256.637061],
                [123, 47529.155256],
                [12.3, 475.291552]
            ];

        [Theory]
        [MemberData(nameof(Invalid))]
        public void ArgumentExceptionTest(double radius)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Circle circle = Circle.New(radius);
            });
        }

        [Theory]
        [MemberData(nameof(Valid))]
        public void CalculateSquareTest(double radius, double result)
        {
            Circle circle = Circle.New(radius);

            double square = circle.CalculateSquare();

            Assert.True(Math.Abs(square - result) < 0.000001);
        }
    }
}
