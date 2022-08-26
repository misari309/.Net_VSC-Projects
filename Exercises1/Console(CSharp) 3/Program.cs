using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Escriba un número de 1 a 7: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine("Do");
                    break;
                case 2:
                    Console.WriteLine("Re");
                    break;
                case 3:
                    Console.WriteLine("Mi");
                    break;
                case 4:
                    Console.WriteLine("Fa");
                    break;
                case 5:
                    Console.WriteLine("Sol");
                    break;
                case 6:
                    Console.WriteLine("La");
                    break;
                case 7:
                    Console.WriteLine("Si");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
