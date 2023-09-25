using Xunit;
using RedCunningFox.Planimetry;
using System;

namespace Tests
{
    public class FigureTest
    {
        [Fact]
        public void TestFigureSorting()
        {
            var circle = new Circle(10);
            var circle2 = new Circle(14);
            var expected = new Figure[] { circle, circle2 };
            Figure[] figures = new Figure[] { circle2, circle };
            Array.Sort(figures);
            Assert.Equal(expected, figures);
        }
    }
}
