using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms.Models
{
#nullable enable
    public static class BubbleSort
    {
        public static int[] Sort(int[]? unsortedArray)
        {
          
            if(unsortedArray == null)
            {
                throw new ArgumentNullException(nameof(unsortedArray));
            }

            int[] sortedArray = unsortedArray;

            for (int i = 0; i < sortedArray.Length; i++)
            {
                for(int j = 0; j < sortedArray.Length - 1; j++)
                {
                    if(sortedArray[j] > sortedArray[j+1])
                    {
                        int temp = sortedArray[j + 1];
                        sortedArray[j + 1] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }
            return sortedArray;
        }
    }
}
