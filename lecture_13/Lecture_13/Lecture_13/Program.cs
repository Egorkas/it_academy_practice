using System;

namespace Lecture_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Uniqueltem uniq = new Uniqueltem();
            Console.WriteLine($"Your id for object - {uniq.Id}");
            Uniqueltem uniq1 = new Uniqueltem();
            Console.WriteLine($"Your id for object - {uniq1.Id}");
            Uniqueltem uniq2 = new Uniqueltem();
            Console.WriteLine($"Your id for object - {uniq2.Id}");
            Uniqueltem uniq3 = new Uniqueltem();
            Console.WriteLine($"Your id for object - {uniq3.Id}");
            Uniqueltem.DisplayId();// ID = 4
        }
    }
}
