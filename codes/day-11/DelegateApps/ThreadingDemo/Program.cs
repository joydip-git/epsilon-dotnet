using System;
using System.Threading;

namespace ThreadingDemo
{
    class Program
    {
        static void Run(object obj)
        {
            int count = (int)obj;
            Console.WriteLine($"Run Thread Id:{Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Run I value:{i}");
            }
        }
        static void Main()
        {
            Console.WriteLine($"Main Thread Id:{Thread.CurrentThread.ManagedThreadId}");
            //ThreadStart runDel = new ThreadStart(Run);
            ParameterizedThreadStart runDel = new ParameterizedThreadStart(Run);
            //Run();
            Thread runThread = new Thread(runDel);
            //runThread.Start();
            runThread.Start(3);
            runThread.Join();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main I value: {i}");
            }
        }
    }
}
