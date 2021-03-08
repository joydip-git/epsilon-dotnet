using System;

namespace PolymorphismDemo
{
    class A { public string name = "A"; }
    class B : A { public string name = "B"; }
    class C : A { public string name = "C"; }
    class Program
    {
        static void Show(B obj)
        {
            System.Console.WriteLine(obj.name);
        }
        static void Show(C obj)
        {
            System.Console.WriteLine(obj.name);
        }

        //compile time polymorphism
        static void Add(int a, int b) { System.Console.WriteLine(a + b); }
        static void Add(int a, int b, int c) { System.Console.WriteLine(a + b + c); }
        static void Add(int a, int b, long l) { System.Console.WriteLine(a + b + l); }
        static void Add(int a, long b, int l) { System.Console.WriteLine(a + b + l); }
        static void Main()
        {
            B obj1 = new B();
            C obj2 = new C();
            Show(obj1);
            Show(obj2);
            Add(10, 12);
            Add(10, 12, 13);
            Add(10, 12, 1234567890123);
            Add(10, 1234567890123, 12);
            // int x = 10;
            // int y = 20;
            // int z = x + y;

            // string firstName = "anil";
            // string lastName = "gupta";
            // string fullName = firstName + lastName;
        }
    }
}
