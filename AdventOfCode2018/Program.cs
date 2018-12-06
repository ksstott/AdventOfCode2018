﻿using System;

namespace AdventOfCode2018
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            Calculate("Day 1 part 1", () => Day1.Part1(Inputs.Day1));
            Calculate("Day 1 part 2", () => Day1.Part2(Inputs.Day1));

            Console.ReadLine();
        }

        private static void Calculate(string dayPartTitle, Func<object> func)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine($"{dayPartTitle}: {func()} - Took {sw.Elapsed.TotalSeconds} seconds");
        }
    }
}
