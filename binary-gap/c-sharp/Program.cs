using System;
using System.Linq;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 9, 529, 20, 15, 32, 51712, 3, 6291457, 561892, 74901729, 805306373, 1073741825 };

            for (int i = 0; i < values.Length; i++)
            {
                int value = values[i];
                int maxLengthOfGap = BinaryGapQuestionAnswerer.Solution(value);

                Console.WriteLine($"{ Convert.ToString(value, 2)} --- > {maxLengthOfGap}");
            }
        }
    }
}
