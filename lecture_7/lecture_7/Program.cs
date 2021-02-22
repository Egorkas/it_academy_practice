using System;

namespace lecture_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = CreateEmptyArr();
            PrintArr(arr);
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
    }
}
