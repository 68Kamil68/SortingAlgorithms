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
                for(int j = 0; j < unsortedArray.Length - 1; j++)
                {
                    if(i < j)
                    {
                        int temp = sortedArray[i];
                        sortedArray[i] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }
            return sortedArray;
        }
    }
}
