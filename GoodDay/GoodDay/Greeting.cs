using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDay
{
    class Greeting
    {
        public static void Greet()
        {
            int thisHour = DateTime.Now.Hour;
            if (thisHour >= 9 && thisHour < 12) Console.WriteLine("Good morning, guys");
            else if (thisHour >= 12 && thisHour < 15) Console.WriteLine("Good day, guys");
            else if (thisHour >= 15 && thisHour < 22) Console.WriteLine("Good evening, guys");
            else Console.WriteLine("Good night!");
        }
    }
}
