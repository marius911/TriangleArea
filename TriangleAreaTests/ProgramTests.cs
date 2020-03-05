using System;
using Xunit;

namespace TriangleArea.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void ComputeDistanceOnSamePoint()
        {
            Point first = new Point(0, 0);
            Point second = new Point(0, 0);

            Assert.True(Program.GetDistanceBetweenPoint(first, second) == 0d);
        }

        [Fact]
        public void TestDistance()
        {
            // 3, 4, 5 are pitagoric numbers
            Point first = new Point(3, 0);
            Point second = new Point(0, 4);

            Assert.True(Program.GetDistanceBetweenPoint(first, second) == 5d);
        }

        [Fact]
        public void ComputeSemiperimeter()
        {
        

            Assert.True(Program.GetSemiPerimeter(2, 4, 4) == 5d);
        }
    }
}
