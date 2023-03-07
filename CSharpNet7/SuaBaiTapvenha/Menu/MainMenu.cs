using SuaBaiTapvenha.Dal;
using SuaBaiTapvenha.ExtentionMethod;
using SuaBaiTapvenha.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuaBaiTapvenha.Menu
{
    internal class MainMenu
    {
        public static void Show()
        {
            DalProduct dal = new();

            while (true)
            {
                Console.WriteLine("Please choose: ");
                Console.WriteLine("1 - add product: ");
                Console.WriteLine("2 - show list: ");
                Console.WriteLine("Not in  (1,2) - exit: ");
                var n = Validate<int>.Input("Please enter number");
                switch (n)
                {
                    case 1:
                        dal.ChangeColor(ConsoleColor.White, ConsoleColor.Black);
                        dal.Add();
                        break;
                    case 2:
                        dal.Show();
                        break;
                    default:
                        dal.ChangeColor(ConsoleColor.Red, ConsoleColor.White);
                        dal.Add();
                        Console.WriteLine("END");
                        return;
                }
            }
        }
    }
}
