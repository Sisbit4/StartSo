using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleStruct
{
    public struct Circle
    {
        private const double Tolerance = 1e-13;

        public double X { get; }
        public double Y { get; }
        public double R { get; }

        public double Length => 2 * Math.PI * R;
        public double Area => Math.PI * R * R;

        public Circle(double x, double y, double r)
        {
            if (r <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            X = x;
            Y = y;
            R = r;
        }

        public override string ToString() =>
            $"Окружность с радиусом {R} с центром в точке ({X}; {Y})";

        public override bool Equals(object obj)
        {
            if (obj is Circle other)
            {
                return Math.Abs(X - other.X) < Tolerance &&
                       Math.Abs(Y - other.Y) < Tolerance &&
                       Math.Abs(R - other.R) < Tolerance;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                hash = hash * 23 + R.GetHashCode();
                return hash;
            }
        }

        public static Circle operator *(double k, Circle c) =>
            new Circle(c.X, c.Y, c.R * k);

        public static Circle operator *(Circle c, double k) => k * c;
    }
}
