﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SortingAlgorithms.Tests
{
    public class BubbleSortTests
    {

        [Fact]
        public void TestBubbleSort()
        {
            // arrange
            int[] unsortedArray = new int[5] { 3, 2, 6, 3, 7 };

            // act
            var actual = Models.BubbleSort.Sort(unsortedArray);
            int[] expected = new int[5] { 2, 3, 3, 6, 7 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBubbleSort2()
        {
            // arrange
            int[] unsortedArray = new int[5] { 5, 4, 3, 2, 1 };

            // act
            var actual = Models.BubbleSort.Sort(unsortedArray);
            int[] expected = new int[5] { 1, 2, 3, 4, 5 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBubbleSort3()
        {
            // arrange
            int[] unsortedArray = new int[5] { 6, 7, 8, 9, 10 };

            // act
            var actual = Models.BubbleSort.Sort(unsortedArray);
            int[] expected = new int[5] { 6, 7, 8, 9, 10 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestBubbleSortAutoGeneratedArray()
        {
            // arrange
            int[] unsortedArray = Models.GenerateUnsortedArray.GenerateArray(10000);
            int[] unsortedArrayCopy = unsortedArray;
            Array.Sort(unsortedArrayCopy);

            // act
            var actual = Models.BubbleSort.Sort(unsortedArray);

            // assert
            Assert.Equal(unsortedArrayCopy, actual);
        }

    }
}
