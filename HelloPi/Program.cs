using System;
using System.IO;
using static System.Console;

namespace HelloPi
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory());
            WriteLine($"Current directtory: {filePath}");
        }
    }
}
