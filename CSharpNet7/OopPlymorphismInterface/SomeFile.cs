using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPlymorphismInterface
{
    internal class SomeFile : IBinaryFile , ITextFile
    {
        public void ReadFile()
        {

        }
        public void WriteBinaryFile() 
        { 
                    
        }
        public void WriteTextFile () 
        {
        }
    }
}
