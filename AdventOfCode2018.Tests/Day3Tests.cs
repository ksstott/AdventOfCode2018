using System;
using Xunit;

namespace AdventOfCode2018.Tests
{
    public class Day3Tests
    {
        [Fact]
        public void Part1_Example_Four()
        {
            string input = "#1 @ 1,3: 4x4\n#2 @ 3,1: 4x4\n#3 @ 5,5: 2x2";

            int result = Day3.Part1(input);

            Assert.Equal(4, result);
        }

        [Fact]
        public void Part1_Example_3()
        {
            string input = "#1 @ 1,3: 4x4\n#2 @ 3,1: 4x4\n#3 @ 5,5: 2x2";

            string result = Day3.Part2(input);

            Assert.Equal("#3", result);
        }
    }
}
