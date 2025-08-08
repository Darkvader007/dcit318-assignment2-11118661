using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Car volvo = new Car();
        Bicycle bmw = new Bicycle();

        volvo.Move();
        bmw.Move();
    }
}