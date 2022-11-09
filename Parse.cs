// Create a function that takes 2 integers in form of a string as an input, and outputs the sum (also as a string

using System;
using System.Numerics;

namespace NewProject
{
    class Program
    {
        public static string Write (string s1, string s2)
        {
            
            int sum = int.Parse(s1) + int.Parse(s2);
            return sum.ToString();
            
        }
        static void Main()
        {
            string s1 = "10";
            string s2 = "13";
            string result = Write (s1, s2);
            Console.WriteLine(result);

        }
    }
}
