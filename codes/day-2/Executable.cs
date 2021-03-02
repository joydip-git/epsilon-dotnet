using System; //System namespace
//using LibraryApp; <-- DLL name (don't mention this if the namespace name is different)
//using LibraryApp; //in case Namespace name and DLL name same
using MyLibrary;

class Executable
{
	static void Main()
	{
		Console.WriteLine("Hello World...");
		
		LibraryCls libraryCls = new LibraryCls();
		string message = libraryCls.SayWelcome("Joydip");
		Console.WriteLine(message);

		Console.WriteLine("Press any key to terminate...");
		Console.ReadLine();
	}
}