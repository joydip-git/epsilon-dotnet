using System;

namespace AnoymousMethod
{
    //storngly-typed delegate
    //delegate int ArithmaticOperation(int first, int second);

    //generic delegate
    delegate TResult ArithmaticOperation<in TInput, out TResult>(TInput first, TInput second);
    //public delegate TResult Func<in T, out TResult>(T arg);
    //public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
    //public delegate TResult Func<in T1, in T2,in T3,...,in T16, out TResult>(T1 arg1, T2 arg2, T3 arg3,.....,T16 arg16);

    class Program
    {
        static void Calculate<TIn, TOut>(ArithmaticOperation<TIn, TOut> operation, TIn a, TIn b)
        {
            Console.WriteLine(operation(a, b));
        }
        static void Main()
        {
            //how to write anonymous method: 1
            Func<int, int, int> add = (a, b) => (a + b);
            ArithmaticOperation<int, int> addOperation = delegate (int x, int y)
             {
                 return (x + y);
             };
            //addOperation(12, 3);
            //how to write anonymous method: 2 (Lambda syntax/Lambda) => Lambda operator
            //2007 (.net framework - 3.0/ C# - 3.0)
            ArithmaticOperation<double, double> multiplyOperation = (a, b) => (a * b);
            //ArithmaticOperation multiplyOperation = new ArithmaticOperation((a, b) => (a * b));
            ArithmaticOperation<long, long> subtractOperation = (m, n) =>
             {
                 return (m - n);
             };
            Calculate<int, int>(addOperation, 12, 3);
            Calculate<double, double>(multiplyOperation, 12.4, 3.2);
            Calculate<long, long>(subtractOperation, 12234, 3456);
        }
    }
}
