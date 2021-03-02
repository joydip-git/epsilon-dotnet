using MessageLibrary;
using System;

namespace TestClient
{
    class UserInterface
    {
        static void Main()
        {
            Messenger messenger = new Messenger();

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            string message = messenger.SayWelCome(name);
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
