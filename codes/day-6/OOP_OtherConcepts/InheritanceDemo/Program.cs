using System;

namespace InheritanceDemo
{
    class D : A
    {
        public D() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Object of which class got create in this line???
            //ans: Child
            // int x = 0;
            // x = 10;

            //child<-- is name of an identifier NOT object
            //casting: upcasting
            A a = null;
            A a1 = null;
            //right hand side of equal sign is the one responsible to create instance
            a = new Child(10, 20, 30, 40);
            a1 = new D();

            //invocation of any ctor DOESNOT mean creation of an instance
            //invocation of any ctor along with new keyword gurantees instance creation

            //i created an instance of Child class and placed the reference of that object in the variable of base class(A)
            //a.M1();
            System.Console.WriteLine(a.SomeData);

            //downcasting
            D actualChildVar = (D)a1;
            Child child = (Child)a;
            child.M1();

            int b = 10;
            long l = b;
            int x = (int)l;
        }
    }
}
