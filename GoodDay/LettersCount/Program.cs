using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your string");
            string usInp = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < usInp.Length; i++)
            {
                if(usInp[i] == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine($"The count of 'a' in input string is {count}");
        }
    }
}
