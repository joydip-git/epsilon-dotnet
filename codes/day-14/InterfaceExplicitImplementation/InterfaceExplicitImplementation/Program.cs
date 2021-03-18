using System;

namespace InterfaceExplicitImplementation
{
    interface IA //dbdataaccess
    {
        void Foo(); //void Open();
        void Foo1();
    }
    interface IB //odbcdataaccess
    {
        void Foo();//void Open()
        void Foo2();
    }
    class Sample : IA, IB
    {        
        void IA.Foo()
        {
            Console.WriteLine("IA Foo");
        }
        void IB.Foo()
        {
            Console.WriteLine("IB Foo");
        }
        //explicit implementation
        void IA.Foo1()
        {
            Console.WriteLine("Foo1");
        }
        //implicit implementation
        public void Foo2()
        {

        }
        public void ClsMethod()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //implicitly implemented methods can be invoked implicitly and explicitly
            //implicit
            Sample sample = new Sample();
            //sample.Foo();
            //sample.Foo1();
            sample.Foo2();
            sample.ClsMethod();

            //explicitly implemented methods can be invoked ONLY explicitly
            //explicit invocation
            IA ia = sample;
            ia.Foo1();
            ia.Foo();
            
            IB ib = sample;
            ib.Foo();
            ib.Foo2();
        }
    }
}
