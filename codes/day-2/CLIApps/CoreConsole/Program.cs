using System;
using CoreLib;

namespace CoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(new Messenger().SayWelcome("Joy"));
            Console.ReadLine();
        }
    }
}
