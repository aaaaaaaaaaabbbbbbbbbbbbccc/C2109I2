using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlymorphismInterface
{
    internal interface IBinaryFile
    {
        //không dùng bổ từ truy cập (access modify)
        void WriteBinaryFile();
        void ReadFile();
        //void có phương thức tồn tại mặc định trong interface
        void ShowInfo() => Console.WriteLine("this is binary");

    }
}
