using System.Diagnostics;
using AdventOfCode2021.Days;
using AdventOfCode2021.Interface;

namespace AOC2020
{
	class Program
	{
		static void Main(string[] args)
		{
			Stopwatch watch = Stopwatch.StartNew();

			IDay day = new Day2();

			Console.WriteLine($"Part1: {day.SolvePart1()}");

			Console.WriteLine($"Part2: {day.SolvePart2()}");

			watch.Stop();
			long elapsedMs = watch.ElapsedMilliseconds;
			Console.WriteLine($"Time Elapsed: {elapsedMs}");
		}
	}
}