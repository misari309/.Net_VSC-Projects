using System;

namespace ConsoleObjectInterface_CSharp_Core__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Console.WriteLine("1. Audi");
            Console.WriteLine("2. Nissan");
            op = Int32.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ICar audiCar = new Audi();
                    audiCar.Sound();
                    audiCar.Accelerate();
                break;
                case 2:
                    ICar nissanCar = new Nissan();
                    nissanCar.Sound();
                    nissanCar.Accelerate();
                break;
            }
        }
    }
}
