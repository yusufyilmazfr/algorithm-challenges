using System;
using System.Collections.Generic;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 1, 2, 3, 4 };
            int[] secondArray = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] thirdArray = new int[] { 0, 0 };

            List<int[]> arrays = new List<int[]>
            {
                firstArray,secondArray,thirdArray
            };

            for (int i = 0; i < arrays.Count; i++)
            {
                var array = arrays[i];
                var newArray = CyclicRotationAnswerer.Solution(array, 6);

                for (int j = 0; j < newArray.Length; j++)
                {
                    Console.Write($"{newArray[j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
