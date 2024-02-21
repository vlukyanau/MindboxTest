using CalculateSquare.Interfaces;


namespace CalculateSquare.Figures
{
    public sealed class Triangle : IFigure
    {
        #region Static
        public static Triangle New(double a, double b, double c)
        {
            if (a <= 0)
                throw new ArgumentException("Side 'A' cannot be less or equals than 0.", nameof(a));

            if (b <= 0)
                throw new ArgumentException("Side 'B' cannot be less or equals than 0.", nameof(b));

            if (c <= 0)
                throw new ArgumentException("Side 'C' cannot be less or equals than 0.", nameof(c));
            
            if (a + b < c || a + c < b || b + c < a)
                throw new ArgumentException("Sides “A”, “B”, “C” do not form triangle.");

            Triangle triangle = new Triangle();
            triangle.A = a;
            triangle.B = b;
            triangle.C = c;

            return triangle;
        }
        #endregion

        #region Constructors
        private Triangle()
        {
        }
        #endregion

        #region Properties
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
        #endregion

        #region IFigure
        public double CalculateSquare()
        {
            double semiperimeter = (this.A + this.B + this.C) / 2;

            double square = Math.Sqrt(semiperimeter * (semiperimeter - this.A) * (semiperimeter - this.B) * (semiperimeter - this.C));

            return square;
        }
        #endregion

        #region Methods
        public bool IsRectangular()
        {
            if (Math.Abs(Math.Pow(this.A, 2d) + Math.Pow(this.B, 2d) - Math.Pow(this.C, 2d)) < double.Epsilon)
                return true;

            if (Math.Abs(Math.Pow(this.A, 2d) + Math.Pow(this.C, 2d) - Math.Pow(this.B, 2d)) < double.Epsilon)
                return true;

            if (Math.Abs(Math.Pow(this.B, 2d) + Math.Pow(this.C, 2d) - Math.Pow(this.A, 2d)) < double.Epsilon)
                return true;

            return false;
        }
        #endregion
    }
}
