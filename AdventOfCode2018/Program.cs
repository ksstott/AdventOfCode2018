using System;

namespace AdventOfCode2018
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            Calculate("Day 1 part 1", () => Day1.Part1(Inputs.Day1));
            Calculate("Day 1 part 2", () => Day1.Part2(Inputs.Day1));
            Calculate("Day 2 part 1", () => Day2.Part1(Inputs.Day2));
            Calculate("Day 2 part 2", () => Day2.Part2(Inputs.Day2));
            Calculate("Day 3 part 1", () => Day3.Part1(Inputs.Day3));
            Calculate("Day 3 part 2", () => Day3.Part2(Inputs.Day3));

            Console.ReadLine();
        }

        private static void Calculate(string dayPartTitle, Func<object> func)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine($"{dayPartTitle}: {func()} - Took {sw.Elapsed.TotalSeconds} seconds");
        }
    }
}
