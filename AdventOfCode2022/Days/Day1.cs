using AdventOfCode2021.Interface;
using System.Collections;

namespace AdventOfCode2021.Days
{
    public class Day1 : IDay
    {
        public string SolvePart1()
        {
            int highest = 0;
            string[] input = Utils.LoadFileToStringArray("Day1-1.txt");

            int currentCounter = 0;
            
            foreach (string item in input)
            {
                if (string.IsNullOrEmpty(item))
                {
                    if (currentCounter > highest)
                    {
                        highest = currentCounter;
                    }
                    currentCounter = 0;
                    continue;
                }
                currentCounter += int.Parse(item);
            }

            return highest.ToString();
        }

        public string SolvePart2()
        {
            List<int> calories = new List<int>();
            string[] input = Utils.LoadFileToStringArray("Day1-1.txt");

            int currentCounter = 0;
            foreach (string item in input)
            {
                if (string.IsNullOrEmpty(item))
                {
                    calories.Add(currentCounter);
                    currentCounter = 0;
                    continue;
                }
                currentCounter += int.Parse(item);
            }

            return calories.OrderByDescending(i => i).Take(3).Sum().ToString();
        }
    }
}
