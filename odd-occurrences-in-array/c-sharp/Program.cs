using System;

namespace OddOccurrencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 3, 5, 7, 9, 13, 3, 1, 5, 7, 9 };
            Console.WriteLine(OddOccurrencesInArrayAnswerer.Solution(numbers));
        }
    }

}
