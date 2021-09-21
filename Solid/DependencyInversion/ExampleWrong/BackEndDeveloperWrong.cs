using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    //Entities must depend on abstractions, not on concretions.
    //It states that the high-level module must not depend on the low-level module, 
    //but they should depend on abstractions.

    public class BackEndDeveloperWrong
    {
        public void writeJava()
        {
            // TODO: implementation of writing code here 
        }
    }
}
