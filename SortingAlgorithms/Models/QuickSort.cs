using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms.Models
{
#nullable enable
    public static class QuickSort
    {
        public static int[] Sort(int[]? unsortedArray)
        {
            if (unsortedArray == null)
            {
                throw new ArgumentNullException(nameof(unsortedArray));
            }
            int[] sortedArray = unsortedArray;
            //Shuffle(new Random(), sortedArray);
            Sort(sortedArray, 0, sortedArray.Length - 1);
            return sortedArray;
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (high <= low)
            {
                return;
            }
            int j = Partition(array, low, high);
            Sort(array, low, j - 1);
            Sort(array, j + 1, high);
        }
    
        public static void Shuffle(this Random? rng, int[]? array)
        {
            if(rng == null || array == null)
            {
                throw new ArgumentNullException();
            }
            int n = array.Length;
            while(n > 1)
            {
                int k = rng.Next(n--);
                int temp = array[n];
                array[k] = temp;
            }
        }

        public static int Partition(int[] array, int low, int high)
        {
            int leftIndex = low;
            int rightIndex = high+1;
            int pivot = array[low];
            while (true)
            {
                while (array[++leftIndex] < pivot)
                {
                    if(leftIndex == high)
                    {
                        break;
                    }
                }
                while (pivot < array[--rightIndex])
                {
                    if(rightIndex == low)
                    {
                        break;
                    }
                }
                if (leftIndex >= rightIndex)
                {
                    break;
                }
                Swap(array, leftIndex, rightIndex);
            }
            Swap(array, low, rightIndex);
            return rightIndex;
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index2];
            array[index2] = array[index1];
            array[index1] = temp;
        }


    }
}
