using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleObject_CSharp__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA obj1 = new ClassA();
            Console.WriteLine("First Object Constructor");
            Console.WriteLine("Enter the first String: ");
            obj1.Var1 = Console.ReadLine();
            Console.WriteLine("Enter the second String: ");
            obj1.Var2 = Console.ReadLine();
            Console.WriteLine("Variable 1: " + obj1.Var1);
            Console.WriteLine("Variable 2: " + obj1.Var2);
            Console.WriteLine("Second Object Overloaded Constructor");
            Console.WriteLine("Enter the first String: ");
            String var1 = Console.ReadLine();
            Console.WriteLine("Enter the second String: ");
            String var2 = Console.ReadLine();
            ClassA obj2 = new ClassA(var1, var2);
            Console.WriteLine("Variable 1: " + obj2.Var1);
            Console.WriteLine("Variable 2: " + obj2.Var2);
            Console.ReadLine();
        }
    }
}
