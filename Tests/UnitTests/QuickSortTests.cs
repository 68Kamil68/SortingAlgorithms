using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SortingAlgorithms.Models;

namespace Tests.UnitTests
{
    public class QuickSortTests
    {
        [Fact]
        public void TestQuickSort()
        {
            // arrange
            int[] unsortedArray = new int[5] { 3, 2, 6, 3, 7 };

            // act
            var actual = QuickSort.Sort(unsortedArray);
            int[] expected = new int[5] { 2, 3, 3, 6, 7 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestQuickSort2()
        {
            // arrange
            int[] unsortedArray = new int[5] { 5, 4, 3, 2, 1 };

            // act
            var actual = QuickSort.Sort(unsortedArray);
            int[] expected = new int[5] { 1, 2, 3, 4, 5 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestQuickSort3()
        {
            // arrange
            int[] unsortedArray = new int[5] { 6, 7, 8, 9, 10 };

            // act
            var actual = QuickSort.Sort(unsortedArray);
            int[] expected = new int[5] { 6, 7, 8, 9, 10 };

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestQuickSort4()
        {
            // arrange
            int[] unsortedArray = GenerateUnsortedArray.GenerateArray(500);
            int[] unsortedArrayCopy = unsortedArray;

            // act
            var actual = QuickSort.Sort(unsortedArray);
            Array.Sort(unsortedArrayCopy);

            // assert
            Assert.Equal(unsortedArrayCopy, actual);
        }

        [Fact]
        public void TestQuickAndBubbleSortWithGeneratedArray()
        {
            // arrange
            int[] unsortedArray = GenerateUnsortedArray.GenerateArray(50);
            int[] unsortedArray2 = unsortedArray;
            // act
            var actual = QuickSort.Sort(unsortedArray);
            int[] expected = BubbleSort.Sort(unsortedArray2);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestQuickSortNullArgument()
        {
            Assert.Throws<ArgumentNullException>(() => QuickSort.Sort(null));
        }
    }

    }
