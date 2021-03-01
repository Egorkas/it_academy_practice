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
            ArrFromThreeEl();
            BoxUnBox();
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

        static void ArrFromThreeEl()
        {
            object[] array = new object[3];
            array[0] = 32;
            array[1] = 'A';
            array[2] = "Hello";
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            array[0] = Convert.ToInt32(array[0]) + 10;
            array[2] = Convert.ToString(array[2]) + ", guys!";
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
        }

        static void BoxUnBox()
        {
            Object boxValue = (short)20;
            sbyte unboxValue = (sbyte)(short)boxValue;
            Console.WriteLine($"\nValue = " + unboxValue + ".Type = " + unboxValue.GetType());
        }
    }
}
