using System;
using System.Linq;
using System.Reflection;

namespace Lecture_16Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            Type myType = typeof(Product);
            var ctor = myType.GetTypeInfo().DeclaredConstructors;
        }
    }
}
