namespace AdventOfCode2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Day1
    {
        public static int Part1(string input)
        {
            return input.Split("\n").Select(int.Parse).Sum();
        }

        public static int Part2(string input)
        {
            Dictionary<int, int> results = new Dictionary<int, int>() { { 0, 1 } };
            int result = 0;
            int i = 0;
            string[] numbers = input.Split("\n");
            while (true)
            {
                result += int.Parse(numbers[i]);

                if (results.ContainsKey(result))
                {
                    return result;
                }
                else
                {
                    results.Add(result, 1);
                }

                i++;
                if (i == numbers.Length)
                {
                    i = 0;
                }
            }
        }
    }
}