using System;
using Xunit;

namespace AdventOfCode2018.Tests
{
    public class Day2Tests
    {
        [Fact]
        public void Part1_Example_Twelve()
        {
            string input = "abcdef\nbababc\nabbcde\nabcccd\naabcdd\nabcdee\nababab";

            int result = Day2.Part1(input);

            Assert.Equal(12, result);
        }

        [Fact]
        public void Part2_Example_fgij()
        {
            for (int i = 0; i < 100000; i++)
            {
                string input = "abcde\nfghij\nklmno\npqrst\nfguij\naxcye\nwvxyz";

                string result = Day2.Part2(input);

                Assert.Equal("fgij", result);
            }
        }
    }
}
