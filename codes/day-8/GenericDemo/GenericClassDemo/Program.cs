using System;

namespace GenericClassDemo
{
    interface ICalculation<T>
    {
        void Add(T a, T b);
        void Subtract(T a, T b);
    }
    class ValueTypeCalculation<TMember> : ICalculation<TMember> where TMember : struct
    {
        TMember[] arr;
        public ValueTypeCalculation()
        {
            arr = new TMember[4];
        }
        public void Add(TMember a, TMember b)
        {

        }
        public void Subtract(TMember a, TMember b)
        {

        }
    }
    class RefTypeCalculation<T> : ICalculation<T> where T : class
    {
        public void Add(T a, T b)
        {
            
        }

        public void Subtract(T a, T b)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeCalculation<int> calculation = new ValueTypeCalculation<int>();
        }
    }
}
