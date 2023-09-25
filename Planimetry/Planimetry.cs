namespace RedCunningFox.Planimetry
{
    public static class Planimetry
    {
        //Можно перенести в абстрактный класс Figure как статичный метод но решил оставить тут
        public static bool IsRightTriangle (IFigure figure) 
        {
            if (figure is Triangle)
            {
                var triangle = (Triangle)figure;
                return triangle.IsRightTriangle;
            }
            else
            {
                throw new ArgumentException("Incorrect figure");
            }
        }

    }
}