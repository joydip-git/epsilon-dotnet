using System;

namespace DynamicPolymorphismDemo
{
    class A
    {
        protected string x;

        public A()
        {
            System.Console.WriteLine("A default ctor");
        }
        public A(string x)
        {
            System.Console.WriteLine("A parameterized ctor");
            this.x = x;
        }

        public void Print()
        {
            System.Console.WriteLine($"X:{x}");
        }
    }
    class B : A
    {
        string y;
        public A()
        {

        }
        public A(int y)
        {
            this.y = y;
        }

        public void Print()
        {
            System.Console.WriteLine($"X:{x} and Y:{y}");
        }
    }
    class C : A { public string name = "C"; }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
