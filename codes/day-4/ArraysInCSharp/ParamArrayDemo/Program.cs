using System;

namespace ParamArrayDemo
{
    class Program
    {
        // static void Add()
        // {

        // }
        //1. all fixed arguments should be declared first
        //2. parameter array should be the last in the function argument list
        //3. only one parameter array can be declared in the method argument list
        static string[] SplitString(string input, string message, params char[] splitters)
        {
            string[] output = new string[100];
            int index = 0;
            string temporary = null;
            foreach (char item in input)
            {
                // if (item != first && item != second && item != third)
                // {
                //     temporary += item;
                // }
                bool isSplitter = false;
                foreach (char splitter in splitters)
                {
                    if (item == splitter)
                    {
                        isSplitter = true;
                        break;
                    }
                }
                if (isSplitter)
                {
                    if (temporary != null)
                    {
                        string word = temporary.Trim();
                        output[index] = temporary;
                        temporary = null;
                        index++;
                    }
                }
                else
                {
                    temporary += item;
                }

            }
            int count = 0;
            foreach (string item in output)
            {
                if (item != null)
                {
                    count++;
                }
            }
            string[] result = new string[count];
            Array.Copy(output, result, count);
            //Console.WriteLine(count);
            return result;
        }
        static void Main(string[] args)
        {
            string input = "I had coffee yesterday at CCD, with my friend, who is from Chennai. He works for Infosys.";
            //string[] words = input.Split(' ', ',', '.');
            //string[] words = input.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            //char[] separators = new char[] { ' ', ',', '.' };
            string[] words = SplitString(input, "hello", ' ', ',', '.');
            //Console.WriteLine(words.Length);
            //string[] wordsNew = SplitString(input, "joy", ' ', ',');
            ShowWords(words);
            // Add(10, 12);
            // Add(10, 12, 13);
        }

        private static void ShowWords(string[] words)
        {
            foreach (string item in words)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
