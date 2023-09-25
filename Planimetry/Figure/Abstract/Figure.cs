using System;

namespace RedCunningFox.Planimetry
{
    public abstract class Figure : IFigure, IComparable<IFigure>
    {
        public virtual double Area { get; }
        public virtual double Perimeter { get; }
        public int CompareTo(IFigure? figure)
        {
            if (figure == null) return 1;
            if (this.Area > figure.Area)
            {
                return 1;
            } 
            else if (this.Area < figure.Area)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
