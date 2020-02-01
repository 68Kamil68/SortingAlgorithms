using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms.Models
{
#nullable enable
    public static class SelectionSort
    {
        public static int[] Sort(int[]? unsortedArray)
        {
            if(unsortedArray == null)
            {
                throw new ArgumentNullException(nameof(unsortedArray));
            }
            int[] sortedArray = unsortedArray;

            for(int i = 0; i < sortedArray.Length; i++)
            {
                int min = i;
                for(int j = i + 1; j < sortedArray.Length; j++)
                {
                    if (sortedArray[j] < sortedArray[min])
                    {
                        min = j;
                    }
                }
                Swap(sortedArray, i, min);
            }
            return sortedArray;
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index2];
            array[index2] = array[index1];
            array[index1] = temp;
        }
    }
}
