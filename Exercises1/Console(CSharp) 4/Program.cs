using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           print1ToN();
        }

        static void print1ToN() 
        {
            int limit = 0;
            Console.WriteLine("Enter the number n: ");
            limit = int.Parse(Console.ReadLine());
            for (int i = 0; i <= limit; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
