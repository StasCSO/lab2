using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Fraction
    {
        double x, y;

        public Fraction(double x, double y)
        {

            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { if (value == 0) this.y = value + 0.0000001; else this.y = value; }
        }

        public static Fraction operator +(Fraction c1, Fraction c2)
        {
            double new_X = c1.X * c2.Y + c2.X * c1.Y;
            double new_Y = c1.Y * c2.Y;

            return new Fraction(new_X, new_Y);
        }

        public static Fraction operator -(Fraction c1, Fraction c2)
        {
            double new_X = c1.X * c2.Y - c2.X * c1.Y;
            double new_Y = c1.Y * c2.Y;

            return new Fraction(new_X, new_Y);
        }

        public static Fraction operator *(Fraction c1, Fraction c2)
        {
            double new_X = c1.X * c2.X;
            double new_Y = c1.Y * c2.Y;

            return new Fraction(new_X, new_Y);
        }

        public static Fraction operator /(Fraction c1, Fraction c2)
        {
            double new_X = c1.X * c2.Y;
            double new_Y = c1.Y * c2.X;

            return new Fraction(new_X, new_Y);
        }

        public static bool operator <(Fraction c1, Fraction c2)
        {
            double first_number = c1.X / c1.Y;
            double second_number = c2.X / c2.Y;

            if (first_number < second_number)
                return true;
            else
                return false;
        }

        public static bool operator >(Fraction c1, Fraction c2)
        {
            double first_number = c1.X / c1.Y;
            double second_number = c2.X / c2.Y;

            if (first_number > second_number)
                return true;
            else
                return false;
        }

        public override String ToString()
        {
            return this.X.ToString() + "/" + this.Y.ToString();
        }

        public Fraction PowTo(double power)
        {
            double new_X = Math.Pow(this.x, power);
            double new_Y = Math.Pow(this.y, power);

            return new Fraction(new_X, new_Y);
        }
    }
}
