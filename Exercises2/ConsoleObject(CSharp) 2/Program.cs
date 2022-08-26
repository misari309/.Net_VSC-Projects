using System;

namespace ConsoleObject_CSharp__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String lastName;
            String country;
            String city;
            Console.WriteLine("Enter the last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the country: ");
            country = Console.ReadLine();
            Console.WriteLine("Enter the city: ");
            city = Console.ReadLine();
            GrandChild grandChild = new GrandChild();
            grandChild.lastName = lastName;
            grandChild.country = country;
            grandChild.city = city;
            Console.WriteLine(grandChild.lastName + " - " + grandChild.country + " - " + grandChild.city);
        }
    }
}
