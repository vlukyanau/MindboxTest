using CalculateSquare.Interfaces;


namespace CalculateSquare.Figures
{
    public sealed class Circle : IFigure
    {
        #region Static
        public static Circle New(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius cannot be less or equals than 0.", nameof(radius));

            Circle circle = new Circle();
            circle.Radius = radius;

            return circle;
        }
        #endregion

        #region Constructors
        private Circle()
        {
        }
        #endregion

        #region Properties
        public double Radius { get; private set; }
        #endregion

        #region IFigure
        public double CalculateSquare()
        {
            double square = Math.PI * Math.Pow(this.Radius, 2d);

            return square;
        }
        #endregion
    }
}
