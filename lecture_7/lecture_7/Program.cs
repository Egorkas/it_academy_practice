using System;

namespace lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateEmptyArr();
            PrintArr(arr);
            MaxValue();
        }

        static void PrintArr(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        static int[] CreateEmptyArr()
        {
            int[] emptyArr = new int[0];
            return emptyArr;
        }

        static void MaxValue()
        {
            int[] array = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 100);
                Console.WriteLine(array[i] + " ");
            }

            Array.Sort(array);
            Console.WriteLine($"Max value in array is {array[array.Length - 1 ]}");
        }
    }
}
