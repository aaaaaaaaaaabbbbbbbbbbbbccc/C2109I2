using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlymorphismInterface
{
    internal class ManyFile : IBinaryFile, ITextFile
    {
        //bỏ đi bổ từ truy cập sau đó thêm interface
        void IBinaryFile.ReadFile()
        {
            Console.WriteLine();
        }
        void ITextFile.WriteBinaryFile()
        {
            Console.WriteLine();
        }
        public void WriteTextFile()
        {
            Console.WriteLine();
        }

        public void WriteBinaryFile()
        {
            throw new NotImplementedException();
        }

        public void ReadFile()
        {
            throw new NotImplementedException();
        }
    }
}
