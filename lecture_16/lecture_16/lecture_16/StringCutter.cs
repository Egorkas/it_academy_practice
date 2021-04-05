using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_16
{
    public static class StringCutter
    {
        public static void CustomeSubstring(this string str)
        {
            if (str.Length >= 5) Console.WriteLine(str.Substring(0, 5));
            else Console.WriteLine($"Your string is too short, so {str}");
        }
    }
}
