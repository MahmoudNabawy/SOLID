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

    //Here we not achieve Dependency Inversion because the project id depend on low level 

    public class ProjectWrong
    {
        private BackEndDeveloper backEndDeveloper = new BackEndDeveloper();
        private FrontEndDeveloper frontEndDeveloper = new FrontEndDeveloper();

        public void implement()
        {
            backEndDeveloper.writeJava();
            frontEndDeveloper.writeJavascript();
        }
    }
}
