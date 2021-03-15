using System;

namespace BasicDelegateDemo
{
    class Calculation
    {
        public void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        public static void Multiply(int first, int second)
        {
            Console.WriteLine(first * second);
        }
    }
    class Downloader
    {
        public string Download(string url)
        {
            return "downloaded data";
        }
    }
}
