using System;
using FirstStandardLibrary;

namespace CoreClient
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(new Messenger().SayWelCome("joydip"));
            Console.ReadLine();
        }
    }
}
