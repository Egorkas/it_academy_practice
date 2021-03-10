using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_10
{
    class Motorcycle
    {
        private int _identificator;
        public string model = "MX-1000";
        public string company = "Minsk";
        public int year;
        public int distance;

        public int Identif
        {
            get { return _identificator; }
            private set { _identificator = value; }
        }

        public Motorcycle()
        {
            
        }
        
    }
}
