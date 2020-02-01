using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SortingAlgorithms.Tests
{
    public class SelectionSortTests
    {
        [Fact]
        public void TestSelectionSort()
        {
            // arrange
            int[] unsortedArray = new int[5] { 3, 2, 6, 3, 7 };

            // act
            var actual = Models.SelectionSort.Sort(unsortedArray);
            int[] expected = new int[5] { 2, 3, 3, 6, 7 };

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
