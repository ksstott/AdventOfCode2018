namespace AdventOfCode2018
{
    using System;
    using System.Linq;

    public class Day2
    {
        public static int Part1(string input)
        {
            string[] ids = input.Split("\n");
            int countOfTwoLetters = 0;
            int countOfThreeLetters = 0;
            foreach (string id in ids)
            {
                var charGroups = id.GroupBy(c => c);
                if (charGroups.Any(g => g.Count() == 2))
                {
                    countOfTwoLetters += 1;
                }
                if (charGroups.Any(g => g.Count() == 3))
                {
                    countOfThreeLetters += 1;
                }
            }

            return countOfTwoLetters * countOfThreeLetters;
        }

        public static string Part2(string input)
        {
            string[] ids = input.Split("\n");
            for (int i = 0; i < ids[0].Length; i++)
            {
                // i is the character we're going to assume is the common character
                var stringsWithoutI = ids.Select(s => $"{s.Substring(0, i)}{s.Substring(i + 1)}");
                var sameStringTwice = stringsWithoutI.GroupBy(s => s).FirstOrDefault(g => g.Count() == 2);
                if (sameStringTwice != null)
                {
                    return sameStringTwice.Key;
                }
            }

            throw new Exception();
        }
    }
}