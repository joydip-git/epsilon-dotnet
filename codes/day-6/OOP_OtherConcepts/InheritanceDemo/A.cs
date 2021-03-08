using System;

namespace InheritanceDemo
{
    class A
    {
        private int someData;
        protected int data;
        public int otherData;

        public A()
        {
            System.Console.WriteLine("A default ctor");
        }

        public A(int a)// : this()
        {
            System.Console.WriteLine("A single parameterized ctor" );
            someData = a;
        }
        public A(int x, int y, int z)// : this(x)
        {
            System.Console.WriteLine("A parameterized ctor");
            someData = x;
            data = y;
            otherData = z;
        }

        public void M1() { System.Console.WriteLine("A class M1"); }

        public int SomeData
        {
            get => someData;
            set => someData = value;
        }
    }
}
