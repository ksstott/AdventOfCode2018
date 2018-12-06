using System;
using Xunit;

namespace AdventOfCode2018.Tests
{
    public class Day1Tests
    {
        [Fact]
        public void Part1_AllPositive_ThreeOutput()
        {
            // Arrange
            string input = "+1\n +1\n +1";

            int result = Day1.Part1(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void Part1_AllNegative_NegativeSixOutput()
        {
            // Arrange
            string input = "-1\n -2\n -3";

            int result = Day1.Part1(input);

            Assert.Equal(-6, result);
        }

        [Fact]
        public void Part1_Mix_ZeroOutput()
        {
            // Arrange
            string input = "-1\n -1\n +2";

            int result = Day1.Part1(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Part2_Example1_ZeroOutput()
        {
            // Arrange
            string input = "+1\n -1";

            int result = Day1.Part2(input);

            Assert.Equal(0, result);
        }

        [Fact]
        public void Part2_Example2_TenOutput()
        {
            // Arrange
            string input = "+3\n +3\n +4\n-2\n-4";

            int result = Day1.Part2(input);

            Assert.Equal(10, result);
        }

        [Fact]
        public void Part2_Example3_FiveOutput()
        {
            // Arrange
            string input = "-6\n +3\n +8\n+5\n-6";

            int result = Day1.Part2(input);

            Assert.Equal(5, result);
        }
    }
}
