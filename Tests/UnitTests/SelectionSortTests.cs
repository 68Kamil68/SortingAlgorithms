using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SortingAlgorithms.Models;

namespace Tests.UnitTests
{
    public class SelectionSortTests
    {
        [Fact]
        public void TestSelectionSort()
        {
            // arrange
            int[] unsortedArray = new int[5] { 3, 2, 6, 3, 7 };

            // act
            var actual = SelectionSort.Sort(unsortedArray);
            int[] expected = new int[5] { 2, 3, 3, 6, 7 };

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
