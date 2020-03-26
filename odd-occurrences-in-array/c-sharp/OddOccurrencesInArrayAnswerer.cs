using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OddOccurrencesInArray
{
    class OddOccurrencesInArrayAnswerer
    {
        public static int Solution(int[] A)
        {
            var orderedA = A.OrderBy(i => i).ToList();

            int i;

            for (i = 0; i < orderedA.Count() - 1 && orderedA[i] == orderedA[i + 1]; i += 2) ;

            return orderedA[i];
        }
    }

}
