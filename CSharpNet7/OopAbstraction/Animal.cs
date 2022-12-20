using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAbstraction
{
    internal abstract class Animal
    {
        //các field 
        private string fullname;
        private int age;

        //1 phương thức không có body {}
        // => nó là abstract
        public abstract void ShowInfo();
    }
}
