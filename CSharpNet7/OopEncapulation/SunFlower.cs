using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapulation
{
    internal class SunFlower : Plant
    {
        static void Main(string[] args)
        {
            SunFlower flower = new();
            flower.Protected();//là con nên được dùng 
            flower.Internal();// trong cùng project/assembly
            flower.PrivateProtected();// hoặc private hoặc là protechted thì được dùng 
            flower.ProtectedInternal();
            flower.Public();
            // flower.Private(); => error vì chỉ đứng tại class đó mới được quyền dùng 
        }
    }
}
