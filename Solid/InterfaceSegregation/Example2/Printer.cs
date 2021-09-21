using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    //A client should never be forced to implement an interface that it doesn’t use, 
    //or clients shouldn’t be forced to depend on methods they do not use.

    public interface Printer
    {
        void print(string file);
    }
}


