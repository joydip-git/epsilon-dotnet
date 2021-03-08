using System;

namespace DynamicPolymorphismDemo
{
    class A
    {
        protected int x;

        public A()
        {
            System.Console.WriteLine("A default ctor");
        }
        public A(int x)
        {
            System.Console.WriteLine("A parameterized ctor");
            this.x = x;
        }

        public virtual void Print()
        {
            System.Console.WriteLine($"X:{x}");
        }
    }
    class B : A
    {
        int y;
        public B()
        {
            System.Console.WriteLine("B default ctor");
        }
        public B(int x, int y) : base(x)
        {
            System.Console.WriteLine("B parameterized ctor");
            this.y = y;
        }

        public override void Print()
        {
            System.Console.WriteLine($"X:{x} and Y:{y}");
        }
    }
    class C : A
    {
        int z;
        public C()
        {
            System.Console.WriteLine("C default ctor");
        }
        public C(int x, int z) : base(x)
        {
            System.Console.WriteLine("C parameterized ctor");
            this.z = z;
        }

        public override void Print()
        {
            //base.Print();
            System.Console.WriteLine($"X:{x} and Z:{z}");
        }
    }
    class Program
    {
        static void Main()
        {
            //A aObj = new A();
            B bObj = new B(10, 20);
            //A sameRef = bObj;
            C cObj = new C(30, 40);
            Show(bObj);
            Show(cObj);
        }
        static void Show(A a)
        {
            a.Print();
            // if (a is B)
            // {
            //     B b = a as B;
            //     b.Print();
            // }
            // if (a is C)
            // {
            //     C c = a as C;
            //     c.Print();
            // }
        }
        // static void Show(B b)
        // {
        //     b.Print();
        // }
        // static void Show(C c)
        // {
        //     c.Print();
        // }
    }
}
