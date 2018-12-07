namespace AdventOfCode2018
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Day3
    {
        public static int Part1(string input)
        {
            Dictionary<string, int> gridSquareCount = new Dictionary<string, int>();
            string[] claims = input.Split("\n");
            foreach (string claim in claims)
            {
                int indexOfAt = claim.IndexOf("@", StringComparison.Ordinal);
                int indexOfComma = claim.IndexOf(",", StringComparison.Ordinal);
                int indexOfColon = claim.IndexOf(":", StringComparison.Ordinal);
                int indexOfX = claim.IndexOf("x", StringComparison.Ordinal);
                int x = int.Parse(claim.Substring(indexOfAt + 2, indexOfComma - indexOfAt - 2));
                int y = int.Parse(claim.Substring(indexOfComma + 1, indexOfColon - indexOfComma - 1));
                int width = int.Parse(claim.Substring(indexOfColon + 2, indexOfX - indexOfColon - 2));
                int height = int.Parse(claim.Substring(indexOfX + 1));

                for (int xi = x; xi < x + width; xi++)
                {
                    for (int yi = y; yi < y + height; yi++)
                    {
                        string coordinates = $"{xi},{yi}";
                        if (gridSquareCount.ContainsKey(coordinates))
                        {
                            gridSquareCount[coordinates] += 1;
                        }
                        else
                        {
                            gridSquareCount.Add(coordinates, 1);
                        }
                    }
                }
            }

            return gridSquareCount.Count(p => p.Value > 1);
        }

        public static string Part2(string input)
        {
            Dictionary<string, string> gridSquareCount = new Dictionary<string, string>();
            Dictionary<string, bool> doesIdClashDictionary = new Dictionary<string, bool>();
            string[] claims = input.Split("\n");
            foreach (string claim in claims)
            {
                int indexOfAt = claim.IndexOf("@", StringComparison.Ordinal);
                int indexOfComma = claim.IndexOf(",", StringComparison.Ordinal);
                int indexOfColon = claim.IndexOf(":", StringComparison.Ordinal);
                int indexOfX = claim.IndexOf("x", StringComparison.Ordinal);
                string id = claim.Substring(0, indexOfAt - 1);
                int x = int.Parse(claim.Substring(indexOfAt + 2, indexOfComma - indexOfAt - 2));
                int y = int.Parse(claim.Substring(indexOfComma + 1, indexOfColon - indexOfComma - 1));
                int width = int.Parse(claim.Substring(indexOfColon + 2, indexOfX - indexOfColon - 2));
                int height = int.Parse(claim.Substring(indexOfX + 1));

                doesIdClashDictionary.Add(id, false);
                for (int xi = x; xi < x + width; xi++)
                {
                    for (int yi = y; yi < y + height; yi++)
                    {
                        string coordinates = $"{xi},{yi}";
                        if (gridSquareCount.ContainsKey(coordinates))
                        {
                            doesIdClashDictionary[gridSquareCount[coordinates]] = true;
                            doesIdClashDictionary[id] = true;
                        }
                        else
                        {
                            gridSquareCount.Add(coordinates, id);
                        }
                    }
                }
            }

            return doesIdClashDictionary.Single(p => !p.Value).Key;
        }
    }
}