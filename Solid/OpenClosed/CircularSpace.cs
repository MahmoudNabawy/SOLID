using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    // Objects or entities should be open for extension but closed for modification.
    // Class Circular inhert from ISpace
    public class CircularSpace : ISpace
    {
        private double radius;

        public void setRadius(double radius)
        {
            this.radius = radius;

        }

        public double getRadius()
        {
            return radius;
        }

         public double area()
        {
            return radius * radius * 3.14;
        }
    }
}
