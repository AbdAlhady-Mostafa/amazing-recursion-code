using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal static class NumExtention
    {
        public static string ReplaceWhiteSpacesWithSlashes(this string value)
        {
            return value.Replace(" ", "/");
        }
        public static string ReverseString(this string value)
        {
           var c = value.ToCharArray();
            Array.Reverse(c);
            return new string(c);
        }
    }
}
