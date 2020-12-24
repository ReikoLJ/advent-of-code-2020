using System.Linq;

namespace AdventOfCode
{
    public class DayOne
    {
        public (int, int) GetEntries(int[] expenseReport)
        {
            foreach (int entry in expenseReport)
            {
                var matchingEntry = expenseReport.Where(x => (x + entry) == 2020).SingleOrDefault();
                
                if(matchingEntry != 0)
                {
                    return (entry, matchingEntry);
                }
            }
            return (0,0);
        }
    }
}
