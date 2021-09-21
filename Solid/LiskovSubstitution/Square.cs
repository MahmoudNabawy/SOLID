using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    public class Square : Rectangle
    {
        //Let q(x) be a property provable about objects of x of type T. 
        //Then q(y) should be provable for objects y of type S where S is a subtype of T.

        // This example not achieve Liskov Substitution

        public Square(double sideLength): base(sideLength, sideLength)
        {
        }

        public new void setWidth(double width)
        {
            base.setWidth(width);
            height = width;
        }

        public new void setHeight(double height)
        {
            base.setHeight(height);
            width = height;
        }
    }
}
