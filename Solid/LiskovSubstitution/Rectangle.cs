using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    //Let q(x) be a property provable about objects of x of type T. 
    //Then q(y) should be provable for objects y of type S where S is a subtype of T.

    // This example not achieve Liskov Substitution
    public class Rectangle
    {
        protected double width;
        protected double height;

        public Rectangle() { }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double getWidth()
        {
            return width;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public String print()
        {
            return String.Format("Rectangle width = {0}  height = {1} ", width, height);
        }
    }
}
