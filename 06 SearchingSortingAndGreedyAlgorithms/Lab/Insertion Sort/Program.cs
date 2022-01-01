using System;
using System.Linq;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BubbleSort(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void BubbleSort(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                var j = i;

                while (j > 0 && numbers[j-1] > numbers[j])
                {
                    Swap(numbers, j, j - 1);
                    j -= 1;
                }
            }
        }

        private static void Swap(int[] numbers, int first, int second)
        {
            var temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
