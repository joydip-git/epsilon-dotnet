using System; //System namespace

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