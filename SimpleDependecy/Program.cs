using System;
using MessagePrinter;

namespace SimpleDependecy
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new MessagePrintingService("The Message");

            service.PrintMessage();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
