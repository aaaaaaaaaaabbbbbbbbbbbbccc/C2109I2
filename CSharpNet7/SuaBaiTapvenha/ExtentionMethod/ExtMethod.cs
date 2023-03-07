using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaBaiTapvenha.ExtentionMethod
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
