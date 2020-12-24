using System;
using AdventOfCode;
using Xunit;

namespace AdventOfCodeUnitTests
{
    public class DayOneTests
    {
        private readonly DayOne _target;

        public DayOneTests()
        {
            _target = new DayOne();
        }

        //Part One
        [Theory]
        [InlineData(new int[] { 1000, 1020, 500, 469 })]
        [InlineData(new int[] { 1721, 979, 366, 299, 675, 1456 })]
        public void PartOne_WhenGivenValidReportList_ReturnsEntriesSumming2020(int[] reportList)
        {
            (var entryOne, var entryTwo) = _target.GetEntriesPartOne(reportList);

            Assert.Equal(2020, entryOne + entryTwo);
        }

        [Fact]
        public void PartOne_WhenGivenInvalidReportList_ThrowsAnException()
        {
            var reportList = new int[] { 200, 111, 500, 469 };

            Assert.Throws<ArgumentException>(() => _target.GetEntriesPartOne(reportList));
        }

        //Part Two
        [Theory]
        [InlineData(new int[] { 1000, 1020, 500, 469 })]
        [InlineData(new int[] { 1721, 979, 366, 299, 675, 1456 })]
        public void PartTwo_WhenGivenValidReportList_ReturnsEntriesSumming2020(int[] reportList)
        {
            (var entryOne, var entryTwo, var entryThree) = _target.GetEntriesPartTwo(reportList);

            Assert.Equal(2020, entryOne + entryTwo + entryThree);
        }

        [Fact]
        public void PartTwo_WhenGivenInvalidReportList_ThrowsAnException()
        {
            var reportList = new int[] { 1, 2, 7, 3 };

            Assert.Throws<ArgumentException>(() => _target.GetEntriesPartTwo(reportList));
        }
    }
}
