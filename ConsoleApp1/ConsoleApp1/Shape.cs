using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
      abstract class Shape
    {
        public abstract void GetArea();
       
    
     }
    class Circle : Shape
    {

        public int radius;
        public const double ConstPI = 2.17;
        public override void GetArea()
        {
            Console.WriteLine(" Enter the length of the radius ");
            radius = Convert.ToInt32( Console.ReadLine());
            double Area = 2 * ConstPI * radius;
            Console.WriteLine($" The Area of the Circle with radius {radius} is {Area} ");
        }


    }

    class Rectangle : Shape
    {
        public int width;
        public int length;

        public override void GetArea()
        {
            Console.WriteLine(" Enter the length; the longer side: ");
            length = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(" Enter the width; the shorter side: ");
            width = Convert.ToInt32( Console.ReadLine());
            int Area = length * width;
            Console.WriteLine($"The Area of the Rectangle is {Area}");
        }


    }
}
