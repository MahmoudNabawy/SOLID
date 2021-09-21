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

    //Here we achieve Dependency Inversion 

    public class Project
    {
        private List<Developer> developers;
        public Project(List<Developer> developers)
        {
            this.developers = developers;
        }

        public void implement()
        {
            foreach (var developer in developers)
            {
                developer.develop();
            }
        }
    }
}
