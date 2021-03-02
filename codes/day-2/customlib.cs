namespace MyLibrary
{
	namespace DataAccess
	{
		public class SqlDataAccess
		{
			public string GetData()
			{
				return "Sql Data";
			}
		}
		public class OracleDataAccess
		{
			public string GetData()
			{
				return "Sql Data";
			}
		}
	}
	namespace Shapes
	{
		public class Rectangle
		{
			public string Draw()
			{
				return "Rectangle";
			}
		}
		public class Triangle
		{
			public string Draw()
			{
				return "Triangle";
			}
		}
	}
	public class MyConsole
	{
		public string WriteLine()
		{
			return "Written";
		}
	}
}