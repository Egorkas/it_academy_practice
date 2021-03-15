using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_10
{
    class Motorcycle
    {
        private Guid _identificator;
        private string _model = "XM-1000";
        private string _company = "Minsk";
        private int _year;
        private int _distance;

        public Guid Identificator
        {
            get
            {
                return _identificator;
            }
            private set
            {
                _identificator = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }
        public int Year
        {
            get
            {
                return DateTime.Now.Year;
            }
            private set
            {
                _year = value;
            }
        }
        public int Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                if(value <= 100)
                _distance = value;
                else
                {
                    Console.WriteLine("Invalid distance! The value must be less or equal 100!!!");
                }
            }
        }

        public void Discharge()
        {
            Identificator = Guid.Empty;
            Model = "XM-1000";
            Company = "Minsk";
            Year = 0;
            Distance = 0;
            Console.WriteLine("All values became default!!!");
        }
                
        public class Engine
        {
            private int _volume;
            private int _power;

            public int Volume
            {
                get
                {
                    return _volume;
                }
                set
                {
                    if(value >= 125 && value <= 3200)
                    _volume = value;
                    else
                    {
                        Console.WriteLine("Invalid volume! The volume must be more or equal 125 and less or equal 3200!!!");
                    }
                }
            }

            public int Power
            {
                get
                {
                    return _power;
                }
                set
                {
                    if(value >= 50 && value <= 300)
                    _power = value;
                    else
                    {
                        Console.WriteLine("Invalid power! The power must be more or equal 50 and less or equal 300!!!");
                    }
                }
            }

        }

        public Motorcycle()
        {
            Identificator = Guid.NewGuid();
        }

    }
}
