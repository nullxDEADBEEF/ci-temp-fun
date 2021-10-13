using System;

namespace CITempFun
{
    public class Program
    {
        public static string FooText(string text)
        {
            Console.WriteLine($"Foo{text}");
            return $"Foo{text}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}