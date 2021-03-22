using System;
using System.Collections.Generic;
using System.Text;

namespace Figure 
{
    class Circle : IFigure
    {
        public int Long { get ; set ; }
        int IFigure.Lat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Circle(int radius)
        {
            Long = radius;
        }
        public double Square()
        {
            return Long * Long * Math.PI;
        }
    }
}
