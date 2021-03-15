using System;

namespace AnoymousMethod
{
    delegate int ArithmaticOperation(int first, int second);
    class Program
    {
        static void Calculate(ArithmaticOperation operation, int a, int b)
        {
            Console.WriteLine(operation(a, b));
        }
        static void Main()
        {
            //how to write anonymous method: 1
            ArithmaticOperation addOperation = delegate (int x, int y)
            {
                return (x + y);
            };

            //how to write anonymous method: 2 (Lambda syntax/Lambda) => Lambda operator
            //2007 (.net framework - 3.0/ C# - 3.0)
            ArithmaticOperation multiplyOperation = (a, b) => (a * b);
            //ArithmaticOperation multiplyOperation = new ArithmaticOperation((a, b) => (a * b));
            ArithmaticOperation subtractOperation = (m, n) =>
            {
                return (m - n);
            };
            Calculate(addOperation, 12, 3);
            Calculate(multiplyOperation, 12, 3);
            Calculate(subtractOperation, 12, 3);
        }
    }
}
