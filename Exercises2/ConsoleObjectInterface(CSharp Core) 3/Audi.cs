using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectInterface_CSharp_Core__3
{
    internal class Audi : ICar
    {
        public void Sound() 
        {
            Console.WriteLine("runnnnn");
        }

        public void Accelerate() 
        {
            Console.WriteLine("The Audi Car is accelerate at 100km/h in 4 seconds.");
        }
    }
}
