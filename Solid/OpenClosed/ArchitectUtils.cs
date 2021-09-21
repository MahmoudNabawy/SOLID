using OpenClosed;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    // Objects or entities should be open for extension but closed for modification.
    // Class ArchitectUtils to calculat area for different shapes
    public class ArchitectUtils
    {
        public double calculateArea(ISpace spaces)
        {
            return spaces.area();
        }
    }
}
