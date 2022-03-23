using System;

namespace first_test_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = true;
            Type strType = str.GetType();
            Console.WriteLine($"str type is {strType}");
            Console.WriteLine("Hello World!");
        }
    }
}
