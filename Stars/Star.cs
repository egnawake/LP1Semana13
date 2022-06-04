using System;

namespace Stars
{
    public class Star : ILightSource, IComparable<Star>
    {
        private const double d = 5.670e-8;

        public double A { get; }
        public double T { get; }
        public double Illuminance => d * A * Math.Pow(T, 4);

        public Star(double area, double temperature)
        {
            A = area;
            T = temperature;
        }

        public int CompareTo(Star other)
        {
            if (other == null)
            {
                return 1;
            }
            if (A == other.A)
            {
                return other.T.CompareTo(T);
            }
            return other.A.CompareTo(A);
        }

        public override string ToString()
        {
            return $"Star (A: {A}, T: {T})";
        }
    }
}
