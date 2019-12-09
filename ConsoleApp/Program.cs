using System;
using ConsoleUtilities;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools consoleTools = new ConsoleTools();
            consoleTools.Write(args);
            Console.ReadKey();
        }
    }
}
