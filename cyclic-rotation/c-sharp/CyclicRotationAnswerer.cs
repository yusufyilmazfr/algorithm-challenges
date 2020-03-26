using System;
using System.Collections.Generic;
using System.Text;

namespace CyclicRotation
{
    class CyclicRotationAnswerer
    {
        public static int[] Solution(int[] A, int K)
        {
            if (K == 0)
            {
                return A;
            }

            int[] newNumbersArray = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                int value = A[i];
                int indexOfNewArray = (i + K) % A.Length;

                newNumbersArray[indexOfNewArray] = value;
            }

            return newNumbersArray;
        }
    }
}
