using System;

namespace GenericDemo
{
    class A
    {
        int aValue;

        public A()
        {

        }

        public A(int aVal)
        {
            aValue = aVal;
        }

        public int AValue { get => aValue; set => aValue = value; }

        public static int operator +(A first, A second)
        {
            return first.AValue + second.AValue;
        }
    }
    class Program
    {
        //static void Add(int a, int b)
        //{

        //}
        //static void Add(double a, double b)
        //{

        //}
        //static void Add(float a, float b)
        //{

        //}
        //generic method with T1 and T2 types where T1 and T2 both are of type A and its subclasses
        //static void Add<T1, T2>(T1 x, T2 y) where T1 : A where T2 : A
        //static void Add<T1, T2>(T1 x, T2 y) where T1 : class where T2 : class
        static void Add<T1, T2>(T1 x, T2 y) where T1 : class, new() where T2 : class, new()
        {
            if (x.GetType() == typeof(A) && y is A)
            {
                A f = x as A;
                A s = y as A;
                Console.WriteLine(f + s);
            }
            //if (x is int && y is int)
            //{
            //    int a = Convert.ToInt32(x);
            //    int b = Convert.ToInt32(y);
            //    Console.WriteLine(a + b);
            //}
        }
        static void Add<T>(T x, T y) where T : struct
        {

        }
        static void Main()
        {
            //T1==T2
            //Add<int, int>(10, 12);

            //T1 != T2
            //Add<int, long>(10, 345678901234);

            Add<A, A>(new A(10), new A(20));


            //float f = 12.34F;
            //decimal d = 12.34M;
            //double db = 12.34D;

            //double d1 = 12.34;

            //Add(10, 12);
            //Add(12.34, 34.56);
            //Add(10.2F, 12.3F);
        }
    }
}
