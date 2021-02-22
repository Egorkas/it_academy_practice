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
            int firstValue = 32;
            object boxingFirstValue = firstValue;
            char secondValue = 'A';
            object boxingSecond = secondValue;
            string thirdValue = "Hello";
            object boxingThird = thirdValue;
            object[] objectArray = new object[3] { boxingFirstValue, boxingSecond, boxingThird };
            for (int i = 0; i < objectArray.Length; i++)
            {
                Console.WriteLine(objectArray[i]);
            }
            objectArray[0] = Convert.ToInt32(objectArray[0]) + 10;
            objectArray[2] = Convert.ToString(objectArray[2]) + ", guys!";
            for (int i = 0; i < objectArray.Length; i++)
            {
                Console.WriteLine(objectArray[i]);
            }
        }

        //static void BoxUnBox()
        //{
        //    short usInp = 20;
        //    Object boxValue = usInp;
        //    sbyte unboxValue = (sbyte)boxValue;
        //    Console.WriteLine($"Value = " + unboxValue + ".Type = " + unboxValue.GetType());
        //}
    }
}
