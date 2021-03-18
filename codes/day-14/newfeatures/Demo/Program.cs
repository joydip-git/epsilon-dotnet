using static System.Console;
//using utilitylibrary;

//static import
using static utilitylibrary.Utility;

namespace Demo
{
    class Program
    {
        static void Test(out int x)
        {

        }
        static void Foo(ref int y)
        {

        }
        static void Main(string[] args)
        {
            WriteLine(GetConnection());
            // int a;
            // Test(out a);
            // Foo(ref a);
            Test(out int a);

            
        }
    }
}
