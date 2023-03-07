using BTVN1_.Dal;
using BTVN1_.Helper;
using BTVN1_.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1_.Menu
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
                Console.WriteLine("2 - delete product: ");
                Console.WriteLine("3 - show list: ");
                Console.WriteLine("Not in  (1,2) - exit: ");
                var n = Validate<int>.Input("Please enter number");
                switch (n)
                {
                    case 1:
                        dal.AddS();
                        dal.ChangeColor(ConsoleColor.White, ConsoleColor.Black);                      
                        break;              
                    case 2:
                        dal.Delete();                       
                        break;
                    case 3:
                        Console.WriteLine("Danh sách sinh viên:");
                        dal.Show();
                        dal.ChangeColor(ConsoleColor.Yellow, ConsoleColor.Black);
                       break;                   
                }
            }
        }
    }
}
