using System;

namespace RedCunningFox.Planimetry
{
    public class Triangle : Figure
    {

        public double AB { get; set; }
        public double BC { get; set; }
        public double AC { get; set; }
        public override double Area { 
            get
            {
                double p = (AB + BC + AC) / 2;
                return Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            }
        }
        public override double Perimeter
        {
            get { return AB + BC + AC; }
        }
        public bool IsRightTriangle
        {
            get
            {
                if ((AB * AB + BC * BC == AC * AC) || (AB * AB + AC * AC == BC * BC) || (AC * AC + BC * BC == AB * AB))
                {
                    return true;
                }
                return false;
            }
        }

        #region Constructors 

        public Triangle (double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Sides of the triangle cannot be less than 0");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Triangle does not exist with this sides");
            }

            AB = a;
            BC = b;
            AC = c;
        }
        #endregion

    }
}
