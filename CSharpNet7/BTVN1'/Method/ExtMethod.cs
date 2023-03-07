using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_.Method
{
    static class ExtMethod
    {
        public static void ChangeColor<T>(this T item, params ConsoleColor[] colors)
        {
            Console.BackgroundColor = colors[0];
            Console.ForegroundColor = colors[1];
        }
    }
}
