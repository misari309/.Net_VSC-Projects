using System;

namespace ConsoleArray_CSharp_Core__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array size: ");
            int size = Int32.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = Int32.Parse(Console.ReadLine());
            }
            float preProm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                preProm = preProm + array[i];
            }
            Console.WriteLine("Average: " + preProm/size);
        }
    }
}
