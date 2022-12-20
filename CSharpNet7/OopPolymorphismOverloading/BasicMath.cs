using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismOverloading
{
    internal class BasicMath
    {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        //overloading (là 1 contructor, 2 là các method)
        //cùng tên chỉ khác tham số hay kiểu của tham số 

        //public BasicMath()
        //{

        //}
        //public BasicMath(int numberOne, int numberTwo)
        //{
        //    NumberOne = numberOne;
        //    NumberTwo = numberTwo;
        //}
        //public BasicMath(int numberOne)
        //{
        //    NumberOne = numberOne;
        //}



        //optional argument => đối số lựa chọn truyền cho tham số
        public void Sum(int num1 = 0, int num2 =default)
        {
            NumberTwo= num2;
            NumberOne= num1;
            Console.WriteLine(NumberOne+NumberTwo);
        }


    }
}