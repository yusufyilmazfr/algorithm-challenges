using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace BinaryGap
{
    class BinaryGapQuestionAnswerer
    {
        public static int Solution(int n)
        {
            var binaries = Convert.ToString(n, 2).ToCharArray();

            if (binaries.Contains('0') == false)
            {
                return 0;
            }

            int maxLengthOfGap = 0;
            int counter = 0;
            int indexOfBinaries = 0;

            while (indexOfBinaries < binaries.Length)
            {
                char value = binaries[indexOfBinaries];
                indexOfBinaries++;

                if (value == '1')
                {
                    if (counter > maxLengthOfGap)
                    {
                        maxLengthOfGap = counter;
                    }

                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

            return maxLengthOfGap;
        }
    }

}
