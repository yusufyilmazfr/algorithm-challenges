using System;
using System.Collections.Generic;
using System.Text;

namespace FrogJmp
{
    class FrogJmpAnswerer
    {
        public static int Solution(int X, int Y, int D)
        {
            int gap = Y - X;

            bool hasCarry = false;

            if (gap % D != 0)
            {
                hasCarry = true;
            }

            return hasCarry ? gap / D + 1 : gap / D;
        }
    }

}
