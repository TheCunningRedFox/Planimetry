using System;

namespace RedCunningFox.Planimetry
{
    /// <summary>
    /// Класс представляет круг
    /// </summary>
    public class Circle : Figure
    {
        public double Radius { get; set; }
        
        public override double Area
        { 
            get 
            {
                return Math.PI* Math.Pow(Radius, 2);
            } 
        }
        public override double Perimeter { 
            get
            {
                return 2 * Radius * Math.PI;
            } 
        }

        #region Constructors

        public Circle (double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Radius cannot be negotiate");
            }
            Radius = radius;
        }

        #endregion
    }
}
