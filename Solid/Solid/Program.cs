using LiskovSubstitution;
using OpenClosed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // OpenClosed Example
            ArchitectUtils ArchitectUtils = new ArchitectUtils();
            CircularSpace CircularSpace = new CircularSpace();
            CircularSpace.setRadius(5);
            Console.WriteLine("CircularSpace: " + ArchitectUtils.calculateArea(CircularSpace));

            RectangularSpace RectangularSpace = new RectangularSpace();
            RectangularSpace.setHeight(5);
            RectangularSpace.setWidth(5);
            Console.WriteLine("RectangularSpace: " + ArchitectUtils.calculateArea(RectangularSpace));


            // LiskovSubstitution Example
            // This example not achieve Liskov Substitution
            Rectangle rectangle = new Rectangle(10, 30);
            Console.WriteLine("Old " + rectangle.print());
            Rectangle newRectangle = extendRectangleWidth(rectangle, 2);
            Console.WriteLine("New " + newRectangle.print());

            Square square = new Square(10);
            Console.WriteLine("Old " + square.print());
            Rectangle newRectangle2 = extendRectangleWidth(square, 2);
            Console.WriteLine("New " + newRectangle2.print());

        }
        public static Rectangle extendRectangleWidth(Rectangle rectangle, int times)
        {
            double newWidth = rectangle.getWidth() * times;
            rectangle.setWidth(newWidth);
            return rectangle;

        }
    }
}
