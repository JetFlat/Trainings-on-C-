using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Index
{
    class Program
    {
        static int[]Massive(int[] array, int index)
        {
            int i = 0;
            int[] newarray = new int[array.Length - 1];
            List<int> list = new List<int>(newarray);
            
            if (index > array.Length)
                return array;
            while (i < index)
            {
                list.Add(array[i++]);
                i++;
            }
            while (i < newarray.Length)
            {
                newarray[i] = array[i + 1];
                i++;
            }            
            
            
            
            return newarray;
        }static void Main()
        {
            int[] test = new int[] { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(test, Console.WriteLine);
            int[] result = Massive(test, 2);
            Array.ForEach(result, Console.WriteLine);
        }
    }
}