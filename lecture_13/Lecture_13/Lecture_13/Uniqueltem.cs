using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_13
{
    class Uniqueltem
    {
        private static int id;

        public static int Id
        { 
            get
            {
                return id;
            } 
            set 
            {
                id = value; 
            } 
        }
        public Uniqueltem()
        {
            id++;
        }

        public static void DisplayId()
        {
            Console.WriteLine($"Your Id is - {Id}");
        }
    }
}
