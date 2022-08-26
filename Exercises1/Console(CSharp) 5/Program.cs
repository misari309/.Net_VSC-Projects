using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_CSharp__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            print_1_To_N_Plus3();
        }

        static void print_1_To_N_Plus3() 
        {
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i=i+3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
