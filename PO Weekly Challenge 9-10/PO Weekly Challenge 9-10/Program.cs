using System;

namespace PO_Weekly_Challenge_9_10
{
    class Program
    {
        static string GiveMeSomething(string a)
        {
            return "something " + a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GiveMeSomething(Console.ReadLine()));
        }
    }
}
