using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopEncapulation
{
    public class Plant
    {
        //access modifier => các bổ từ truy cập 
        private void Private() => Console.WriteLine("private");
        protected void Protected() => Console.WriteLine("Protected");
        internal void Internal() => Console.WriteLine("Internal");
        private protected void PrivateProtected() => Console.WriteLine(" private protected");
        protected internal void ProtectedInternal() => Console.WriteLine("protectedInternal");
        public void Public() => Console.WriteLine("public");
        static void Main(string[] args)
        {
            Plant plant = new();
            plant.Private();
            plant.Protected();
            plant.ProtectedInternal();
            plant.Internal();
            plant.PrivateProtected();
            plant.Public();

        }
    }












}
