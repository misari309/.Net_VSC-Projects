using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            int n = int.Parse(Console.ReadLine());
            while (c<n)
            {
                Console.WriteLine(c);
                c = a + b;
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
