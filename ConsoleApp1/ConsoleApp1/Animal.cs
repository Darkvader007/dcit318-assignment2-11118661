using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Eiiiii");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound() 
        { 
               Console.WriteLine("Bark");  
        }
    }
}
