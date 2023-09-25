using Xunit;
using RedCunningFox.Planimetry;
using System;

namespace Tests
{
    public class CircleTest
    {
        [Fact]
        public void TestCircleCalculateArea()
        {
            double r = 3;
            double expected = 28.27;
            var circle = new Circle(r);
            double circleSquare = Math.Round(circle.Area, 2);
            Assert.Equal(expected, circleSquare);
        }

        [Fact]
        public void TestCircleCalculatePerimeter()
        {
            double r = 10;
            double expected = 62.8;
            var circle = new Circle(r);
            double circleSquare = Math.Round(circle.Perimeter, 1);
            Assert.Equal(expected, circleSquare);
        }
    }
}