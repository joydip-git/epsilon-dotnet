using System;
using CoreFirstLibrary;

namespace CoreFirstClient
{
    class Program
    {
        static void Main()
        {
            Messenger messenger = new Messenger();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            string message = messenger.SayWelCome(name);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
