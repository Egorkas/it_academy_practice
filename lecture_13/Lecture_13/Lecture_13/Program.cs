using System;

namespace Lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start value of Id");
            Uniqueltem.Id = Int32.Parse(Console.ReadLine());
            Uniqueltem uniq = new Uniqueltem();
            Uniqueltem uniq1 = new Uniqueltem();
            Uniqueltem uniq2 = new Uniqueltem();
            Uniqueltem uniq3 = new Uniqueltem();
            Uniqueltem.DisplayId();// ID = 4
        }
    }
}
