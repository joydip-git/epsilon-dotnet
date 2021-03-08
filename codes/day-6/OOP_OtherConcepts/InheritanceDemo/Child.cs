using System;

namespace InheritanceDemo
{
    class Child : A
    {
        public int bData;
        //public Child():base(10)
        public Child() : base(10, 20, 30)
        {
            System.Console.WriteLine("Child default ctor");
        }

        // public Child(int x, int y, int z, int m) : base(x)
        public Child(int x, int y, int z, int m) : base(x, y, z)
        {
            System.Console.WriteLine("Child parameterized ctor");
            // this.someData = x;
            // this.data = y;
            // this.otherData = z;
            this.bData = m;
            //this.SomeData = 100;
            //base.SomeData = 100;
        }

        public void M1()
        {
            base.M1();
            System.Console.WriteLine("Child class M1");
        }
    }

   
}
