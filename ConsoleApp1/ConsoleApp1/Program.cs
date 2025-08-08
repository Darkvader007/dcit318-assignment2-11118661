using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {

       Shape small_circle = new Circle();
        small_circle.GetArea();

        Shape parallelogram = new Rectangle();
        parallelogram.GetArea();
    }
}