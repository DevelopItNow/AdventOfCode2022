using AdventOfCode2021.Interface;
using System.Collections;

namespace AdventOfCode2021.Days
{
    public class Day2 : IDay
    {
        public string SolvePart1()
        {
            var pointsTable = new Dictionary<(char, char), int>
            {
                { ('A', 'X'), 4 },
                { ('A', 'Y'), 8 },
                { ('A', 'Z'), 3 },
                { ('B', 'X'), 1 },
                { ('B', 'Y'), 5 },
                { ('B', 'Z'), 9 },
                { ('C', 'X'), 7 },
                { ('C', 'Y'), 2 },
                { ('C', 'Z'), 6 }
            };

            string[] rounds = Utils.LoadFileToStringArray("Day2-1.txt");

            int score = 0;

            foreach (string round in rounds)
            {
                score += pointsTable[(round[0], round[2])];
            }

            return score.ToString();
        }

        public string SolvePart2()
        {
            var pointsTable = new Dictionary<(char, char), int>
            {
                { ('A', 'X'), 3 },
                { ('A', 'Y'), 4 },
                { ('A', 'Z'), 8 },
                { ('B', 'X'), 1 },
                { ('B', 'Y'), 5 },
                { ('B', 'Z'), 9 },
                { ('C', 'X'), 2 },
                { ('C', 'Y'), 6 },
                { ('C', 'Z'), 7 }
            };

            string[] rounds = Utils.LoadFileToStringArray("Day2-1.txt");

            int score = 0;

            foreach (string round in rounds)
            {
                score += pointsTable[(round[0], round[2])];
            }

            return score.ToString();
        }
    }
}
