using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_13
{
    class Uniqueltem
    {
        private static int _id = 0;

        public int Id { get; set; }
        public Uniqueltem()
        {
            _id++;
            Id = _id;
        }

        public static void DisplayId()
        {
            Console.WriteLine($"Your Id is - {_id}");
        }
    }
}
