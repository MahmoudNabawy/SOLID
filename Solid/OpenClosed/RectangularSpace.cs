using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    // Objects or entities should be open for extension but closed for modification.
    // Class Rectangular inhert from ISpace
    public class RectangularSpace : ISpace
    {
        private double width;
        private double height;

        public void setWidth(double width)
        {
            this.width = width;

        }

        public void setHeight(double height)
        {
            this.height = height;

        }

        public double getWidth()
        {
            return width;
        }

        public double getHeight()
        {
            return height;
        }

        public double area()
        {
            return width * height;
        }
    }
}
