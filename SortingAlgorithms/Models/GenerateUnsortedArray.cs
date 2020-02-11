using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SortingAlgorithms.Models
{
    public static class GenerateUnsortedArray
    {
        public static int[] GenerateArray(int size)
        {

            int[] unsortedArray = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                unsortedArray[i] = rand.Next(0, 1000);
            }
            return unsortedArray;
        }
    }
}
