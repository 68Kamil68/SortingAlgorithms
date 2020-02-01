using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms.Models
{
    public static class MergeSort
    {
        private static int[] helperArray;
        public static int[] Sort(int[] unsortedArray)
        {
            helperArray = new int[unsortedArray.Length];
            var sortedArray = unsortedArray;
            Sort(sortedArray, 0, unsortedArray.Length - 1);
            return sortedArray;
        }

        private static void Sort(int[] array, int low, int high)
        {
            if (high <= low)
            {
                return;
            }
            int mid = low + (high - low) / 2;
            Sort(array, low, mid);
            Sort(array, mid + 1, high);
            Merge(array, low, mid, high);
        }

        public static void Merge(int[] array, int low, int mid, int high)
        {
            int i = low;
            int j = mid + 1;

            for (int k = low; k <= high; k++)
            {
                helperArray[k] = array[k];
            }

            for (int k = low; k <= high; k++)
            {
                if (i > mid)
                {
                    array[k] = helperArray[j++];
                }
                else if (j > high)
                {
                    array[k] = helperArray[i++];
                }
                else if (helperArray[j] < helperArray[i])
                {
                    array[k] = helperArray[j++];
                }
                else
                {
                    array[k] = helperArray[i++];
                }
            }
        }
    }
}
