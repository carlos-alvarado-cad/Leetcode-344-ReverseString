using System;

namespace LC344ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] test = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(test);
            foreach(char letter in test)
            {
                Console.WriteLine(letter);
            }
        }

        public static char[] ReverseString(char[] c)
        {
            char front;
            char back;
            for (int i = 0, j = c.Length - 1; i < c.Length / 2; i++, j--)
            {
                front = c[i];
                back = c[j];

                c[i] = back;
                c[j] = front;
            }
            return c;
        }
    }
}
