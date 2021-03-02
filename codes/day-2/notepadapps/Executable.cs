using System; //System namespace
//using LibraryApp; <-- DLL name (don't mention this if the namespace name is different)
//using LibraryApp; //in case Namespace name and DLL name same
using MyLibrary; //<--customlib.dll & LibraryApp.dll
//using MyLibrary.DataAccess;
//using MyLibrary.Shapes;

namespace MyExecutable
{
	class Executable
	{
		static void Main()
		{
			Console.WriteLine("Hello World...");
		
			//LibraryApp.dll-->MyLibrary namespace
			LibraryCls libraryCls = new LibraryCls();
			string message = libraryCls.SayWelcome("Joydip");
			Console.WriteLine(message);
			
			/*
			*/
			
			//customlib.dll-->MyLibrary.DataAccess namespace
			//SqlDataAccess sqlDataAccess = new SqlDataAccess();
			//string sqlData = sqlDataAccess.GetData();
			//Console.WriteLine(sqlData);
			
			//customlib.dll-->MyLibrary.Shapes namespace
			//Rectangle rectangle = new Rectangle();
			//string recShape = rectangle.Draw();
			//Console.WriteLine(recShape);
			
			//customlib.dll-->MyLibrary namespace
			MyConsole myConsole = new MyConsole();
			string writtenData = myConsole.WriteLine();
			Console.WriteLine(writtenData);

			Console.WriteLine("Press any key to terminate...");
			Console.ReadLine();
		}
	}
}