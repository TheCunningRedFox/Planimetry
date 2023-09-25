using Xunit;
using RedCunningFox.Planimetry;
using System;

namespace Tests
{
    public class TriangleTest
    {
        [Fact]
        public void TestTriangleGetArea()
        {
            double a = 14;
            double b = 13;
            double c = 15;
            double expected = 84;
            var triangle = new Triangle(a, b, c);
            double triangleSquare = triangle.Area;
            Assert.Equal(expected, Math.Round(triangleSquare, 2));
        }

        [Fact]
        public void TestTriangleGetPerimeter()
        {
            double a = 14;
            double b = 13;
            double c = 15;
            double expected = 42;
            var triangle = new Triangle(a, b, c);
            double triangleSquare = triangle.Perimeter;
            Assert.Equal(expected, triangleSquare);
        }

        [Fact]
        public void TestTriangleIsRightTrue()
        {
            double a = 5;
            double b = 13;
            double c = 12;
            bool expected = true;
            var triangle = new Triangle(a, b, c);
            bool isRightTriangle = Planimetry.IsRightTriangle(triangle);
            Assert.Equal(expected, isRightTriangle);
        }

        [Fact]
        public void TestTriangleIsRightFalse()
        {
            double a = 5;
            double b = 12;
            double c = 12;
            bool expected = false;
            var triangle = new Triangle(a, b, c);
            bool isRightTriangle = Planimetry.IsRightTriangle(triangle);
            Assert.Equal(expected, isRightTriangle);
        }
    }
}