using System;
using System.Linq;

namespace AdventOfCode
{
    public class DayOne
    {
        private const int EntrySumGoal = 2020;

        public (int, int) GetEntriesPartOne(int[] expenseReport)
        {
            foreach (int entry in expenseReport)
            {          
                var matchingEntry = expenseReport.Where(x => ValuesEqualSumGoal(entry, x)).SingleOrDefault();

                if (matchingEntry != 0)
                {
                    return (entry, matchingEntry);
                }
            }

            throw new ArgumentException($"No matching entries found which sum to {EntrySumGoal}");
        }

        public (int, int, int) GetEntriesPartTwo(int[] expenseReport)
        {
            foreach (int entry in expenseReport)
            {
                foreach (int entry2 in expenseReport)
                {
                    var entry3 = expenseReport.Where(x => ValuesEqualSumGoal(entry, entry2, x)).SingleOrDefault();
                    
                    if (entry3 != 0)
                    {
                        return (entry, entry2, entry3);
                    }
                }
            }
            throw new ArgumentException($"No matching entries found which sum to {EntrySumGoal}");
        }

        private bool ValuesEqualSumGoal(int valueOne, int valueTwo, int valueThree = 0)
        {
            return valueOne + valueTwo + valueThree == EntrySumGoal;
        }
    }
}