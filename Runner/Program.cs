using AdventOfCode;
using System;
using System.Linq;

namespace Runner
{
    class Program
    {
        static void Main(string[] args)
        {
            //DayOne
            var dayOne = new DayOne();
            int[] reportList = PuzzleInputValues.DayOneInput.Split(',').Select(int.Parse).ToArray();

            RunPartOne(dayOne, reportList);
            RunPartTwo(dayOne, reportList);
        }

        private static void RunPartOne(DayOne dayOne, int[] reportList)
        {
            (var entryOne, var entryTwo) = dayOne.GetEntriesPartOne(reportList);

            Console.WriteLine($"EntryOne: {entryOne}. EntryTwo: {entryTwo}.");
            Console.WriteLine($"Multiplicaton Result: {entryOne * entryTwo}");
            Console.ReadKey();
        }

        private static void RunPartTwo(DayOne dayOne, int[] reportList)
        {
            (var entryOne, var entryTwo, var entryThree) = dayOne.GetEntriesPartTwo(reportList);

            Console.WriteLine($"EntryOne: {entryOne}. EntryTwo: {entryTwo}. EntryThree: {entryThree}.");
            Console.WriteLine($"Multiplicaton Result: {entryOne * entryTwo * entryThree}");
            Console.ReadKey();
        }
    }
}
