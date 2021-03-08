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
            //casting
            //Child child = (Child)a;
            //or as operator
            Child child = a as Child;
            child.M1();

            int b = 10;
            long l = b;
            //is operator can't be used with value type
            //if(b is int){}
            //if(typeof(int) is b){}
            
            int x = (int)l; //use casting
            // int x = l as int; //<-- as operator can't be used with value type

            //reference of child object can be placed in a variable of base as well as child class
            //if the reference of child object is placed in a variable of base class, then base class members from child object can be invoked
            //if the reference of child object is placed in a variable of child class itself, then base as well as child class members from child object can be invoked
            //if the reference of child object is placed in a variable of child class itself, in case of similar (M1 method for example) members, child member will be invoked
            // in this case if you want to invoke the same base member, invoke it from child member itslef in child class code
        }
    }
}
