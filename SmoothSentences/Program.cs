using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;


// Program for adventofCode.com

namespace SmoothSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> positions = new List<string> { };
            foreach (string line in System.IO.File.ReadLines("Positions.txt"))
            {
                positions.Add(line);
            }
            var pos = positions.Select(int.Parse).ToList();
            int x = CalcNumberOfIncreases(pos);
            Console.WriteLine(x);

        }
        private static int CalcNumberOfIncreases(List<int> input)
        {
            int count = 0;
            int i = 1;
            while(i < input.Count())
            {
                if (input[i] > input[i - 1]) count++;
                i++;
            }
            return count;
        }
    }
}
