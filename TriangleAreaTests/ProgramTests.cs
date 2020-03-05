using System;
using Xunit;

namespace TriangleArea.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void TestDistance()
        {
            Point first = new Point(0, 7);
            Point second = new Point(0, 2);
            Assert.True(Program.GetDistanceBetweenPoint(first, second) == 5d);
        }
    }
}
