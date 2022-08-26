using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleObjectInterface_CSharp_Core__3
{
    internal class Nissan : ICar
    {
        public void Sound()
        {
            Console.WriteLine("runnnnn rrrrrrrrrrrrrrrrrrrrrrun");
        }

        public void Accelerate()
        {
            Console.WriteLine("The Nissan Car is accelerate at 120km/h in 3.5 seconds.");
        }
    }
}
