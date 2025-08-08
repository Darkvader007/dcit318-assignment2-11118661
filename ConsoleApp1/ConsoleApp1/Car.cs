using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    public interface Imovable
    {
        void Move();
    } 
    
     class Car : Imovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : Imovable 
    {
        public void Move()
        { 
         Console.WriteLine("Bicycle is moving");
        }
    }
}
